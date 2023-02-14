namespace SmartBar
{
    partial class FrmIzvjestajInventurniZapisnik
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerInventura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(EntitiesLayer.Entities.Product);
            // 
            // reportViewerInventura
            // 
            this.reportViewerInventura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsProducts";
            reportDataSource2.Value = this.productBindingSource;
            this.reportViewerInventura.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerInventura.LocalReport.ReportEmbeddedResource = "SmartBar.reportAllProducts.rdlc";
            this.reportViewerInventura.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInventura.Name = "reportViewerInventura";
            this.reportViewerInventura.ServerReport.BearerToken = null;
            this.reportViewerInventura.Size = new System.Drawing.Size(740, 414);
            this.reportViewerInventura.TabIndex = 0;
            // 
            // FrmIzvjestajInventurniZapisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 414);
            this.Controls.Add(this.reportViewerInventura);
            this.Name = "FrmIzvjestajInventurniZapisnik";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Trenutni inventurni zapisnik";
            this.Load += new System.EventHandler(this.FrmIzvjestajInventurniZapisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventura;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}