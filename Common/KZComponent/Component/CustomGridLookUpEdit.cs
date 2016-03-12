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
using System.Threading.Tasks;
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
using Framework.Base.Helper;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using MainInfrastructure.Controller;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace GridLookUpEdit_MultiAutoSearch
{
    [UserRepositoryItem("RegisterCustomGridLookUpEdit")]
    public class RepositoryItemCustomGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        #region default

        static RepositoryItemCustomGridLookUpEdit() { RegisterCustomGridLookUpEdit(); }

        public RepositoryItemCustomGridLookUpEdit()
        {
            TextEditStyle = TextEditStyles.Standard;
            AutoComplete = false;
        }
        [Browsable(false)]
        public override TextEditStyles TextEditStyle { get { return base.TextEditStyle; } set { base.TextEditStyle = value; } }
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

        #endregion  
    }


    public class CustomGridLookUpEdit : GridLookUpEdit
    {

        #region Defalut
        static CustomGridLookUpEdit() { RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit(); }
        

        public override string EditorTypeName { get { return RepositoryItemCustomGridLookUpEdit.CustomGridLookUpEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomGridLookUpEdit Properties { get { return base.Properties as RepositoryItemCustomGridLookUpEdit; } }


        #endregion

        #region custom

        public Action<IModelBase> OnSelectionChangeAction { get; set; }


        public KZBindingList<IModelBase> AdditionalModelsList { get; set; }
        private bool _isAdditionalModelsOnTop = true;
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
        private IModelBase SelectedModel
        {
            get
            {
                try
                {

                    var model = GetSelectedDataRow() as IModelBase;
                    
                    return model;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }


        public RepositoryItemCustomGridLookUpEdit InPlaceRepositoryPopUp { get; set; }


        private int _popUpMaxHeight = 300;
        [Category("Customization")]
        public int PopUpMaxHeight
        {
            set { _popUpMaxHeight = value; }
            get { return _popUpMaxHeight; }
        }
        private int _gridViewWidth = 0;
        [Category("Customization")]
        public int GridViewWidth
        {
            get { return _gridViewWidth == 0 ? Width : _gridViewWidth; }
            set { _gridViewWidth = value; }
        }


        public void RefreshGridLookUp(IUnityContainer container, IModelBase defaultValueModel)
        {
            Properties.DataSource = null;
            Properties.View.Columns.Clear();
            EditValueChanged -= gridLookUpEdit_EditValueChanged;
            InitGridLookUp(container, defaultValueModel);
        }

        public void InitLookup(IUnityContainer container, IModelBase defaultValueModel)
        {
            if (_alreadyInit) return;
            _alreadyInit = true;

            InitGridLookUp(container, defaultValueModel);

        }

        private void InitGridLookUp(IUnityContainer container, IModelBase defaultValueModel)
        {
            InitGridLookUpType(container, defaultValueModel);


            Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            Properties.ValidateOnEnterKey = true;
            Properties.AllowNullInput = DefaultBoolean.True;
            Properties.AutoComplete = false;

            EditValueChanged += gridLookUpEdit_EditValueChanged;

            if (InitGridLookUpTypeActions != null && InitGridLookUpTypeActions.ContainsKey(GridLookUpType))
                InitGridLookUpTypeActions[GridLookUpType].Invoke(container, defaultValueModel);
            
        }
        protected void PostCompleteAsyn<T>(PLinqServerModeSource pLinqServerModeSource, IModelBase defaultValueModel)
        {


            
            AddAdditionalModel<T>(pLinqServerModeSource);



            var models = pLinqServerModeSource.Source as IEnumerable<T>;


            var model = defaultValueModel;
            int selectedValue = 0;
            if (model != null && model.Id != 0)
            {
                selectedValue = model.Id;
            }
            else 
            {
                if (models != null)
                {
                    IModelBase selectedModel = null;


                    foreach (var contactModel in models)
                    {
                        selectedModel = contactModel as IModelBase;
                        break;
                    }
                    if (selectedModel != null) selectedValue = selectedModel.Id;
                }
            }


            Properties.DataSource = pLinqServerModeSource;

            if (InPlaceRepositoryPopUp != null)
                InPlaceRepositoryPopUp.DataSource = Properties.DataSource;

            if (Properties.View.Columns.Count == 1)
                Properties.View.OptionsView.ShowColumnHeaders = false;
           

            if (_gridViewWidth != 0)
                Properties.BestFitMode = BestFitMode.BestFit;

            if (models != null)
            {
                var height = (models.Count() * 31) + 36;

                if (_popUpMaxHeight > 0 && height > _popUpMaxHeight)
                    Properties.PopupFormSize = new Size(GridViewWidth, _popUpMaxHeight);
                else
                {
                    Properties.PopupFormSize = new Size(GridViewWidth, height);
                }
            }

            EditValue = selectedValue;
            
        }

        private void AddAdditionalModel<T>(PLinqServerModeSource pLinqServerModeSource)
        {
            var source = pLinqServerModeSource.Source;

            try
            {
                if (AdditionalModelsList == null || AdditionalModelsList.Count == 0) return;

                if (_isAdditionalModelsOnTop)
                {
                    var list = new KZBindingList<T>();

                    if (AdditionalModelsList != null)
                    {

                        foreach (var model in AdditionalModelsList)
                        {
                            list.Add((T) model);

                        }
                    }
                    if (source != null)
                    {
                        foreach (var model in source)
                        {
                            list.Add((T) model);
                        }
                    }
                    pLinqServerModeSource.Source = list;
                }
                else
                {
                    var list = new KZBindingList<T>();
                    if (source != null)
                    {
                        foreach (var model in source)
                        {
                            list.Add((T)model);
                        }
                    }
                    if (AdditionalModelsList != null)
                    {

                        foreach (var model in AdditionalModelsList)
                        {
                            list.Add((T)model);

                        }
                    }
                   
                    pLinqServerModeSource.Source = list;
                }
            }
            catch
            {
                pLinqServerModeSource.Source = source;
            }
        }
        private IDictionary<string, Action<IUnityContainer, IModelBase>> InitGridLookUpTypeActions { get; set; }

        protected virtual void InitGridLookUpType(IUnityContainer container, IModelBase defaultValueModel)
        {
            InitGridLookUpTypeActions = new Dictionary<string, Action<IUnityContainer, IModelBase>>();

            var kzHelper = container.Resolve<IKZHelper>();



            InitGridLookUpTypeActions.Add(kzHelper.GridLookUpTypes.Customer, InitCustomer);
            InitGridLookUpTypeActions.Add(kzHelper.GridLookUpTypes.CustomList, InitCustomList);
        }

        public IModelBase QueryModel { get; set; }

        private void InitCustomer(IUnityContainer container, IModelBase defaultValueModel)
        {

            var kzHelper = container.Resolve<IKZHelper>();

            var message = kzHelper.KZMessage.CreateMessage(container.Resolve<IContactController>(), QueryModel);
            
            Func<object, KZResult<IContactModel>> worker = (arg) =>
            {
                var msg = arg as IKZMessage;
                var controller = msg.Controller as IContactController;
                var queryModel = msg.Model as IContactModel;

                return controller?.GetCustomers(queryModel);
            };

            Action<Task<KZResult<IContactModel>>> completeWork = (taskResult) =>
            {

                var results = taskResult.Result;
                var pLinqServerModeSource = new PLinqServerModeSource {Source = results.Models};
               

                this.Properties.DisplayMember = "Name";
                this.Properties.ValueMember = "Id";

                GridColumn col1 = this.Properties.View.Columns.AddField("Name");
                col1.VisibleIndex = 0;
                col1.Caption = Resource.translate.Customer;

                PostCompleteAsyn<IContactModel>(pLinqServerModeSource, defaultValueModel);
                
            };
            kzHelper.KZAsynchronousTask.StartTask(worker, completeWork, message);
        }


        private void InitCustomList(IUnityContainer container, IModelBase defaultValueModel)
        {
            
            var pLinqServerModeSource = new PLinqServerModeSource();
            

            this.Properties.DisplayMember = "Name";
            this.Properties.ValueMember = "Id";

            GridColumn col1 = this.Properties.View.Columns.AddField("Name");
            col1.VisibleIndex = 0;
            col1.Caption = " ";
            
            PostCompleteAsyn<IModelBase>(pLinqServerModeSource, defaultValueModel);

        }


        bool _alreadyInit = false;
        

        void gridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.Tag = SelectedModel;
            OnSelectionChangeAction?.Invoke(SelectedModel);
        }

        public void ClearSelectedGridLookUp()
        {
            EditValue = null;
        }

        public string GridLookUpType { get; set; }

        public void CreateInPlaceRepositoryPopUp(string displayTextField)
        {
            InPlaceRepositoryPopUp = new RepositoryItemCustomGridLookUpEdit
            {
                View = Properties.View,
                ShowDropDown = ShowDropDown.Never,
                AutoHeight = true,
                DisplayMember = displayTextField,
                PopupFormSize = Size,
                TextEditStyle = TextEditStyles.Standard,
            };

            InPlaceRepositoryPopUp.EditValueChanged += gridLookUpEdit_EditValueChanged;

        }

        


        #endregion

        


    }


}