using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Data.PLinq;
using DevExpress.Utils;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Framework.Base.App;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using GridLookUpEdit_MultiAutoSearch;
using Microsoft.Practices.Unity;

namespace BTRMComComponent
{
    public partial class ComboBoxGridLookup : CustomGridLookUpEdit
    {
        public ComboBoxGridLookup()
        {
            InitializeComponent();
        }
        
        private IModelBase SelectedModel
        {
            get
            {
                try
                {
                    var model = this.GetSelectedDataRow() as IModelBase;
                    return model;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        
        public Action<IModelBase> OnSelectionChangeAction { get; set; }
        public IKZBindingList<IModelBase> AdditionalModelsList { get; set; }

        private bool _isAdditionalModelsOnTop = true;
        
        public void CreateInPlaceRepositoryPopUp(string displayTextField)
        {
            InPlaceRepositoryPopUp = new RepositoryItemCustomGridLookUpEdit
            {
                View = this.gridLookUpEditView,
                ShowDropDown = ShowDropDown.Never,
                AutoHeight = true,
                DisplayMember = displayTextField,
                PopupFormSize = this.Size,
                TextEditStyle = TextEditStyles.Standard,
            };

            InPlaceRepositoryPopUp.EditValueChanged += InPlaceRepositoryPopUp_EditValueChanged;

        }

        void InPlaceRepositoryPopUp_EditValueChanged(object sender, EventArgs e)
        {
            OnSelectionChangeAction?.Invoke(SelectedModel);
        }
        
        public RepositoryItemCustomGridLookUpEdit InPlaceRepositoryPopUp { get; set; }



        public bool IsAdditionalModelsOnTop
        {
            get
            {
                return _isAdditionalModelsOnTop;
            }
            set
            {
                _isAdditionalModelsOnTop = value;

            }
        }



        public string GridLookUpType { get; set; }

        [Category("Customization")]
        public int EditorWidth
        {
            set { this.Width = value; }
            get { return this.Width; }
        }

        private int _popUpMaxHeight = 300;

        [Category("Customization")]
        public int PopUpMaxHeight
        {
            set { this._popUpMaxHeight = value; }
            get { return _popUpMaxHeight; }
        }

        [Category("Customization")]
        public Font EditorFont
        {
            set { this.Font = value; }
            get { return this.Font; }
        }

      
        

        #region GridLookUp


        public void ClearSelectedGridLookUp()
        {
            this.EditValue = null;
        }


        public void RefreshGridLookUp(IUnityContainer container, IModelBase defaultValueModel)
        {
            this.Properties.DataSource = null;
            this.Properties.View.Columns.Clear();
            this.EditValueChanged -= gridLookUpEdit_EditValueChanged;
            InitGridLookUp(container, defaultValueModel);
        }

        protected void PostCompleteAsyn(PLinqServerModeSource pLinqServerModeSource, int selectedValue)
        {
            this.Properties.DataSource = pLinqServerModeSource;

            if (InPlaceRepositoryPopUp != null)
                InPlaceRepositoryPopUp.DataSource = this.Properties.DataSource;

            if (this.Properties.View.Columns.Count == 1)
                this.Properties.View.OptionsView.ShowColumnHeaders = false;
            var source = pLinqServerModeSource.Source as IEnumerable<IModelBase>;

            if (_gridViewWidth != 0)
                this.Properties.BestFitMode = BestFitMode.BestFit;

            if (source != null)
            {
                var height = (source.Count() * 31) + 36;

                if (_popUpMaxHeight > 0 && height > _popUpMaxHeight)
                    this.Properties.PopupFormSize = new Size(GridViewWidth, _popUpMaxHeight);
                else
                {
                    this.Properties.PopupFormSize = new Size(GridViewWidth, height);
                }
            }

            this.EditValue = selectedValue;

            IsBindCompleted = true;
        }


        public  bool IsBindCompleted { get; set; }

        
        private int _gridViewWidth = 0;

        [Category("Customization")]
        public int GridViewWidth
        {
            get { return _gridViewWidth == 0 ? EditorWidth : _gridViewWidth; }
            set { _gridViewWidth = value; }
        }

        private void AddAdditionalModel<T>(PLinqServerModeSource pLinqServerModeSource)
        {


            var source = pLinqServerModeSource.Source;

            try
            {
                if (AdditionalModelsList == null || AdditionalModelsList.Count == 0) return;

                if (_isAdditionalModelsOnTop)
                {
                    var index = 0;
                    var list = new KZBindingList<T>();
                    if (pLinqServerModeSource.Source != null)
                        list = new KZBindingList<T>(pLinqServerModeSource.Source as IEnumerable<T>);
                    foreach (var model in AdditionalModelsList)
                    {

                        if (list != null)
                            list.Insert(index++, (T)model);

                    }

                    pLinqServerModeSource.Source = list.Where(s => true);
                }
                else
                {
                    var list = new KZBindingList<T>();
                    if (pLinqServerModeSource.Source != null)
                        list = new KZBindingList<T>(pLinqServerModeSource.Source as IEnumerable<T>);
                    foreach (var model in AdditionalModelsList)
                    {
                        list.Add((T)model);
                    }

                    pLinqServerModeSource.Source = list.Where(s => true);
                }
            }
            catch
            {
                pLinqServerModeSource.Source = source;
            }
        }
        

        public bool CreateIfNotExist { get; set; }
        

        
        public IDictionary<string, Action<IUnityContainer, IModelBase>> InitGridLookUpTypeActions { get; set; }

        protected virtual void InitGridLookUpType(IUnityContainer container,  IModelBase defaultValueModel)
        {
            InitGridLookUpTypeActions = new Dictionary<string, Action<IUnityContainer, IModelBase>>();

            var helper = container.Resolve<IKZHelper>();
            
        }

        private void InitGridLookUp(IUnityContainer container, IModelBase defaultValueModel)
        {
            InitGridLookUpType(container, defaultValueModel);

            if (InitGridLookUpTypeActions != null && InitGridLookUpTypeActions.ContainsKey(GridLookUpType))
                InitGridLookUpTypeActions[GridLookUpType].Invoke(container, defaultValueModel);

            this.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            this.Properties.ValidateOnEnterKey = true;
            this.Properties.AllowNullInput = DefaultBoolean.True;
            this.Properties.AutoComplete = false;

            //Event
            this.EditValueChanged += gridLookUpEdit_EditValueChanged;

        }


        void gridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            OnSelectionChangeAction?.Invoke(this.SelectedModel);
        }

        #endregion

        #region Init

        bool _alreadyInit = false;

        public void InitLookup(IUnityContainer container, IModelBase defaultValueModel)
        {
            if (_alreadyInit) return;
            _alreadyInit = true;

            InitGridLookUp(container, defaultValueModel);

        }


        #endregion




    }
}
