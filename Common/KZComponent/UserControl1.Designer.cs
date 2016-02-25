using GridLookUpEdit_MultiAutoSearch;

namespace KZComponent
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridLookUpEdit = new GridLookUpEdit_MultiAutoSearch.CustomGridLookUpEdit();
            this.gridLookUpEditView = new GridLookUpEdit_MultiAutoSearch.CustomGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookUpEdit
            // 
            this.gridLookUpEdit.AdditionalModelsList = null;
            this.gridLookUpEdit.CreateIfNotExist = false;
            this.gridLookUpEdit.EditValue = "";
            this.gridLookUpEdit.GridLookUpType = null;
            this.gridLookUpEdit.GridViewWidth = 355;
            this.gridLookUpEdit.InitGridLookUpTypeActions = null;
            this.gridLookUpEdit.InPlaceRepositoryPopUp = null;
            this.gridLookUpEdit.IsAdditionalModelsOnTop = true;
            this.gridLookUpEdit.IsBindCompleted = false;
            this.gridLookUpEdit.Location = new System.Drawing.Point(140, 86);
            this.gridLookUpEdit.Margin = new System.Windows.Forms.Padding(0);
            this.gridLookUpEdit.Name = "gridLookUpEdit";
            this.gridLookUpEdit.OnSelectionChangeAction = null;
            this.gridLookUpEdit.PopUpMaxHeight = 300;
            this.gridLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEdit.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject1.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            serializableAppearanceObject1.Options.UseFont = true;
            this.gridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gridLookUpEdit.Properties.NullText = "";
            this.gridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.gridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpEdit.Properties.View = this.gridLookUpEditView;
            this.gridLookUpEdit.Size = new System.Drawing.Size(355, 30);
            this.gridLookUpEdit.TabIndex = 12;
            // 
            // gridLookUpEditView
            // 
            this.gridLookUpEditView.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.DetailTip.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.DetailTip.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.Empty.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.Empty.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.EvenRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.EvenRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FilterPanel.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FixedLine.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.FixedLine.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FocusedCell.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.FocusedCell.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FocusedRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditView.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FooterPanel.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupButton.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.GroupButton.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupFooter.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupPanel.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Romnea", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.HorzLine.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.HorzLine.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.OddRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.OddRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.Preview.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.Row.Font = new System.Drawing.Font("Khmer OS Battambang", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditView.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.RowSeparator.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.RowSeparator.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.SelectedRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.SelectedRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.TopNewRow.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.VertLine.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.VertLine.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.ViewCaption.Font = new System.Drawing.Font("Khmer OS Battambang", 10F);
            this.gridLookUpEditView.Appearance.ViewCaption.Options.UseFont = true;
            this.gridLookUpEditView.FixedLineWidth = 1;
            this.gridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEditView.Name = "gridLookUpEditView";
            this.gridLookUpEditView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpEditView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpEditView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpEditView.OptionsBehavior.Editable = false;
            this.gridLookUpEditView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridLookUpEditView.OptionsDetail.AllowZoomDetail = false;
            this.gridLookUpEditView.OptionsDetail.EnableMasterViewMode = false;
            this.gridLookUpEditView.OptionsDetail.ShowDetailTabs = false;
            this.gridLookUpEditView.OptionsDetail.SmartDetailExpand = false;
            this.gridLookUpEditView.OptionsFilter.AllowFilterEditor = false;
            this.gridLookUpEditView.OptionsFind.AllowFindPanel = false;
            this.gridLookUpEditView.OptionsHint.ShowCellHints = false;
            this.gridLookUpEditView.OptionsHint.ShowColumnHeaderHints = false;
            this.gridLookUpEditView.OptionsHint.ShowFooterHints = false;
            this.gridLookUpEditView.OptionsMenu.EnableColumnMenu = false;
            this.gridLookUpEditView.OptionsMenu.EnableFooterMenu = false;
            this.gridLookUpEditView.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEditView.OptionsSelection.UseIndicatorForSelection = false;
            this.gridLookUpEditView.OptionsView.ShowDetailButtons = false;
            this.gridLookUpEditView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridLookUpEditView.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEditView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpEditView.OptionsView.ShowIndicator = false;
            this.gridLookUpEditView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridLookUpEdit);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(797, 313);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGridLookUpEdit gridLookUpEdit;
        private CustomGridView gridLookUpEditView;
    }
}
