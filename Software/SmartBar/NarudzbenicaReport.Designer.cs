namespace SmartBar
{
    partial class NarudzbenicaReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrderFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsOrderForm";
            reportDataSource1.Value = this.OrderFormBindingSource;
            reportDataSource2.Name = "DsOrderItem";
            reportDataSource2.Value = this.OrderItemBindingSource;
            reportDataSource3.Name = "DsProduct";
            reportDataSource3.Value = this.productBindingSource;
            reportDataSource4.Name = "DsSupplier";
            reportDataSource4.Value = this.supplierBindingSource;
            reportDataSource5.Name = "DsUser";
            reportDataSource5.Value = this.userBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartBar.rptNarudzbenicaDetalji.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OrderFormBindingSource
            // 
            this.OrderFormBindingSource.DataSource = typeof(EntitiesLayer.Entities.OrderForm);
            this.OrderFormBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // OrderItemBindingSource
            // 
            this.OrderItemBindingSource.DataSource = typeof(EntitiesLayer.Entities.OrderItem);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(EntitiesLayer.Entities.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(EntitiesLayer.Entities.Supplier);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(EntitiesLayer.Entities.User);
            // 
            // NarudzbenicaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "NarudzbenicaReport";
            this.Text = "NarudzbenicaReport";
            this.Load += new System.EventHandler(this.NarudzbenicaReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrderFormBindingSource;
        private System.Windows.Forms.BindingSource OrderItemBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}