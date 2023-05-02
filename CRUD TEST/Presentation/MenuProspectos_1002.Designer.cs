namespace CRUD_TEST.Presentation
{
    partial class MenuProspectos_1002
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProspectosvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.prospectoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rowId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFirstName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLastName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNumberPhone = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowClient = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDateRegister = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.ProspectosvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProspectosvGridControl
            // 
            this.ProspectosvGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProspectosvGridControl.DataSource = this.prospectoInfoBindingSource;
            this.ProspectosvGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProspectosvGridControl.Location = new System.Drawing.Point(0, 20);
            this.ProspectosvGridControl.Name = "ProspectosvGridControl";
            this.ProspectosvGridControl.OptionsBehavior.Editable = false;
            this.ProspectosvGridControl.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.ProspectosvGridControl.OptionsSelectionAndFocus.MultiSelect = true;
            this.ProspectosvGridControl.OptionsSelectionAndFocus.MultiSelectMode = DevExpress.XtraVerticalGrid.MultiSelectMode.RowSelect;
            this.ProspectosvGridControl.OptionsView.ShowRecordHeaders = true;
            this.ProspectosvGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemDateEdit1});
            this.ProspectosvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowId,
            this.rowFirstName,
            this.rowLastName,
            this.rowNumberPhone,
            this.rowClient,
            this.rowDateRegister});
            this.ProspectosvGridControl.Size = new System.Drawing.Size(800, 430);
            this.ProspectosvGridControl.TabIndex = 0;
            // 
            // prospectoInfoBindingSource
            // 
            this.prospectoInfoBindingSource.DataSource = typeof(CRUD_TEST_CORE.Entities.ProspectoInfo);
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // rowId
            // 
            this.rowId.Enabled = false;
            this.rowId.Height = 16;
            this.rowId.Name = "rowId";
            this.rowId.Properties.Caption = "Id";
            this.rowId.Properties.FieldName = "Id";
            // 
            // rowFirstName
            // 
            this.rowFirstName.Enabled = false;
            this.rowFirstName.Name = "rowFirstName";
            this.rowFirstName.Properties.Caption = "First Name";
            this.rowFirstName.Properties.FieldName = "FirstName";
            // 
            // rowLastName
            // 
            this.rowLastName.Enabled = false;
            this.rowLastName.Name = "rowLastName";
            this.rowLastName.Properties.Caption = "Last Name";
            this.rowLastName.Properties.FieldName = "LastName";
            // 
            // rowNumberPhone
            // 
            this.rowNumberPhone.Enabled = false;
            this.rowNumberPhone.Name = "rowNumberPhone";
            this.rowNumberPhone.Properties.Caption = "Number Phone";
            this.rowNumberPhone.Properties.FieldName = "NumberPhone";
            // 
            // rowClient
            // 
            this.rowClient.Enabled = false;
            this.rowClient.Name = "rowClient";
            this.rowClient.Properties.Caption = "Client";
            this.rowClient.Properties.FieldName = "Client";
            // 
            // rowDateRegister
            // 
            this.rowDateRegister.Enabled = false;
            this.rowDateRegister.Name = "rowDateRegister";
            this.rowDateRegister.Properties.Caption = "Date Register";
            this.rowDateRegister.Properties.DrawEditorBorder = true;
            this.rowDateRegister.Properties.FieldName = "DateRegister";
            this.rowDateRegister.Properties.RowEdit = this.repositoryItemDateEdit1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nueva";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
            // 
            // MenuProspectos_1002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProspectosvGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MenuProspectos_1002";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuProspectos_1002";
            ((System.ComponentModel.ISupportInitialize)(this.ProspectosvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl ProspectosvGridControl;
        private System.Windows.Forms.BindingSource prospectoInfoBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowId;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFirstName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLastName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNumberPhone;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowClient;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDateRegister;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}