namespace SmartBar
{
    partial class FrmGrafičkiPrikazInventara
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProducts
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProducts.Legends.Add(legend1);
            this.chartProducts.Location = new System.Drawing.Point(186, 35);
            this.chartProducts.Name = "chartProducts";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Proizvodi";
            this.chartProducts.Series.Add(series1);
            this.chartProducts.Size = new System.Drawing.Size(677, 511);
            this.chartProducts.TabIndex = 1;
            this.chartProducts.Text = "chartProducts";
            // 
            // FrmGraphProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 578);
            this.Controls.Add(this.chartProducts);
            this.Name = "FrmGraphProduct";
            this.Text = "Grafički prikaz stanja inventara";
            this.Load += new System.EventHandler(this.FrmGraphProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
    }
}