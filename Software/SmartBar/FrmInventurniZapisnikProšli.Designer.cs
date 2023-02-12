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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.inventoryRecordItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsInventory";
            reportDataSource1.Value = this.inventoryRecordItemBindingSource;
            reportDataSource2.Name = "DsRecord";
            reportDataSource2.Value = this.inventoryRecordBindingSource;
            reportDataSource3.Name = "DsProduct";
            reportDataSource3.Value = this.productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartBar.reportIzvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(823, 477);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Izvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Izvjestaj";
            this.Text = "Inventurni zapisnik";
            this.Load += new System.EventHandler(this.Izvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRecordItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inventoryRecordItemBindingSource;
        private System.Windows.Forms.BindingSource inventoryRecordBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}