namespace BTRMComComponent
{
    partial class ComboBoxGridLookup
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
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditView)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(355, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 34);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(355, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 34);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(355, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 34);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gridLookUpEdit, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 34);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // gridLookUpEdit
            // 
            this.gridLookUpEdit.EditValue = "";
            this.gridLookUpEdit.Location = new System.Drawing.Point(0, 0);
            this.gridLookUpEdit.Margin = new System.Windows.Forms.Padding(0);
            this.gridLookUpEdit.Name = "gridLookUpEdit";
            this.gridLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEdit.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject1.Font = new System.Drawing.Font("Khmer OS System", 10F);
            serializableAppearanceObject1.Options.UseFont = true;
            this.gridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gridLookUpEdit.Properties.NullText = "";
            this.gridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.gridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpEdit.Properties.View = this.gridLookUpEditView;
            this.gridLookUpEdit.Size = new System.Drawing.Size(355, 34);
            this.gridLookUpEdit.TabIndex = 12;
            // 
            // gridLookUpEditView
            // 
            this.gridLookUpEditView.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.DetailTip.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.DetailTip.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.Empty.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.Empty.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.EvenRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.EvenRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FilterPanel.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FixedLine.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.FixedLine.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FocusedCell.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.FocusedCell.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FocusedRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditView.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.FooterPanel.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupButton.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.GroupButton.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupFooter.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupPanel.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.GroupRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Khmer Viravuth", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.HorzLine.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.HorzLine.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.OddRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.OddRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.Preview.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.Row.Font = new System.Drawing.Font("Khmer Nettra", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditView.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.RowSeparator.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.RowSeparator.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.SelectedRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.SelectedRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.TopNewRow.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.VertLine.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.gridLookUpEditView.Appearance.VertLine.Options.UseFont = true;
            this.gridLookUpEditView.Appearance.ViewCaption.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
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
            // ComboBoxGridLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Khmer Nettra", 9.75F);
            this.Name = "ComboBoxGridLookup";
            this.Size = new System.Drawing.Size(355, 34);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEditView;
        protected DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit;



    }
}
