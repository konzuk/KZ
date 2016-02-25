using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.Data.PLinq;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using Framework.Base.App;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using Microsoft.Practices.Unity;

namespace GridLookUpEdit_MultiAutoSearch
{
    [UserRepositoryItem("RegisterCustomGridLookUpEdit")]
    public class RepositoryItemCustomGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemCustomGridLookUpEdit() { RegisterCustomGridLookUpEdit(); }

        public RepositoryItemCustomGridLookUpEdit()
        {
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            AutoComplete = false;
        }
        [Browsable(false)]
        public override DevExpress.XtraEditors.Controls.TextEditStyles TextEditStyle { get { return base.TextEditStyle; } set { base.TextEditStyle = value; } }
        public const string CustomGridLookUpEditName = "CustomGridLookUpEdit";

        public override string EditorTypeName { get { return CustomGridLookUpEditName; } }

        public static void RegisterCustomGridLookUpEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomGridLookUpEditName,
              typeof(CustomGridLookUpEdit), typeof(RepositoryItemCustomGridLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true));
        }

        protected override GridView CreateViewInstance() { return new CustomGridView(); }
        protected override GridControl CreateGrid() { return new CustomGridControl(); }
    }


    public class CustomGridLookUpEdit : GridLookUpEdit
    {
        static CustomGridLookUpEdit() { RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit(); }

        public CustomGridLookUpEdit() : base() { }

        public override string EditorTypeName { get { return RepositoryItemCustomGridLookUpEdit.CustomGridLookUpEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomGridLookUpEdit Properties { get { return base.Properties as RepositoryItemCustomGridLookUpEdit; } }


        public Action<IModelBase> OnSelectionChangeAction { get; set; }

        public IKZBindingList<IModelBase> AdditionalModelsList { get; set; }

        private bool _isAdditionalModelsOnTop = true;

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

        private int _popUpMaxHeight = 300;

        [Category("Customization")]
        public int PopUpMaxHeight
        {
            set { this._popUpMaxHeight = value; }
            get { return _popUpMaxHeight; }
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


        public bool IsBindCompleted { get; set; }


        private int _gridViewWidth = 0;

        [Category("Customization")]
        public int GridViewWidth
        {
            get { return _gridViewWidth == 0 ? this.Width : _gridViewWidth; }
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

        protected virtual void InitGridLookUpType(IUnityContainer container, IModelBase defaultValueModel)
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
        bool _alreadyInit = false;

        public void InitLookup(IUnityContainer container, IModelBase defaultValueModel)
        {
            if (_alreadyInit) return;
            _alreadyInit = true;

            InitGridLookUp(container, defaultValueModel);

        }

        void gridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            OnSelectionChangeAction?.Invoke(this.SelectedModel);
        }
        public void ClearSelectedGridLookUp()
        {
            this.EditValue = null;
        }


        public string GridLookUpType { get; set; }

        public void CreateInPlaceRepositoryPopUp(string displayTextField)
        {
            InPlaceRepositoryPopUp = new RepositoryItemCustomGridLookUpEdit
            {
                View = this.Properties.View,
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


    }


}