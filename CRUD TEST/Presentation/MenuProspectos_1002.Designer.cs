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
            this.rowId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFirstName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLastName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNumberPhone = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowClient = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDateRegister = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.prospectoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ProspectosvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ProspectosvGridControl
            // 
            this.ProspectosvGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProspectosvGridControl.DataSource = this.prospectoInfoBindingSource;
            this.ProspectosvGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProspectosvGridControl.Location = new System.Drawing.Point(0, 0);
            this.ProspectosvGridControl.Name = "ProspectosvGridControl";
            this.ProspectosvGridControl.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.ProspectosvGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemDateEdit1});
            this.ProspectosvGridControl.RowHeaderWidth = 104;
            this.ProspectosvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowId,
            this.rowFirstName,
            this.rowLastName,
            this.rowNumberPhone,
            this.rowClient,
            this.rowDateRegister});
            this.ProspectosvGridControl.Size = new System.Drawing.Size(800, 450);
            this.ProspectosvGridControl.TabIndex = 0;
            // 
            // rowId
            // 
            this.rowId.Height = 16;
            this.rowId.Name = "rowId";
            this.rowId.Properties.Caption = "Id";
            this.rowId.Properties.FieldName = "Id";
            // 
            // rowFirstName
            // 
            this.rowFirstName.Name = "rowFirstName";
            this.rowFirstName.Properties.Caption = "First Name";
            this.rowFirstName.Properties.FieldName = "FirstName";
            // 
            // rowLastName
            // 
            this.rowLastName.Name = "rowLastName";
            this.rowLastName.Properties.Caption = "Last Name";
            this.rowLastName.Properties.FieldName = "LastName";
            // 
            // rowNumberPhone
            // 
            this.rowNumberPhone.Name = "rowNumberPhone";
            this.rowNumberPhone.Properties.Caption = "Number Phone";
            this.rowNumberPhone.Properties.FieldName = "NumberPhone";
            // 
            // rowClient
            // 
            this.rowClient.Name = "rowClient";
            this.rowClient.Properties.Caption = "Client";
            this.rowClient.Properties.FieldName = "Client";
            // 
            // rowDateRegister
            // 
            this.rowDateRegister.Name = "rowDateRegister";
            this.rowDateRegister.Properties.Caption = "Date Register";
            this.rowDateRegister.Properties.DrawEditorBorder = true;
            this.rowDateRegister.Properties.FieldName = "DateRegister";
            this.rowDateRegister.Properties.RowEdit = this.repositoryItemDateEdit1;
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
            // MenuProspectos_1002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProspectosvGridControl);
            this.Name = "MenuProspectos_1002";
            this.Text = "MenuProspectos_1002";
            ((System.ComponentModel.ISupportInitialize)(this.ProspectosvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

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
    }
}