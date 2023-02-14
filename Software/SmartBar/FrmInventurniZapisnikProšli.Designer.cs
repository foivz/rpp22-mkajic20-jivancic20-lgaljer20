namespace SmartBar
{
    partial class FrmInventurniZapisnikProšli
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.inventoryRecordItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvZapisnik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRecordItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryRecordItemBindingSource
            // 
            this.inventoryRecordItemBindingSource.DataSource = typeof(EntitiesLayer.Entities.InventoryRecordItem);
            // 
            // inventoryRecordBindingSource
            // 
            this.inventoryRecordBindingSource.DataSource = typeof(EntitiesLayer.Entities.InventoryRecord);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(EntitiesLayer.Entities.Product);
            // 
            // rvZapisnik
            // 
            this.rvZapisnik.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DsInventory";
            reportDataSource4.Value = this.inventoryRecordItemBindingSource;
            reportDataSource5.Name = "DsRecord";
            reportDataSource5.Value = this.inventoryRecordBindingSource;
            reportDataSource6.Name = "DsProduct";
            reportDataSource6.Value = this.productBindingSource;
            this.rvZapisnik.LocalReport.DataSources.Add(reportDataSource4);
            this.rvZapisnik.LocalReport.DataSources.Add(reportDataSource5);
            this.rvZapisnik.LocalReport.DataSources.Add(reportDataSource6);
            this.rvZapisnik.LocalReport.ReportEmbeddedResource = "SmartBar.reportIzvjestaj.rdlc";
            this.rvZapisnik.Location = new System.Drawing.Point(0, 0);
            this.rvZapisnik.Name = "rvZapisnik";
            this.rvZapisnik.ServerReport.BearerToken = null;
            this.rvZapisnik.Size = new System.Drawing.Size(823, 477);
            this.rvZapisnik.TabIndex = 0;
            // 
            // FrmInventurniZapisnikProšli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 477);
            this.Controls.Add(this.rvZapisnik);
            this.Name = "FrmInventurniZapisnikProšli";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Inventurni zapisnik";
            this.Load += new System.EventHandler(this.FrmInventurniZapisnikProšli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRecordItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvZapisnik;
        private System.Windows.Forms.BindingSource inventoryRecordItemBindingSource;
        private System.Windows.Forms.BindingSource inventoryRecordBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}