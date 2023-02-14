namespace SmartBar
{
    partial class FrmGrafickiPrikazInventara
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProducts
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProducts.Legends.Add(legend3);
            this.chartProducts.Location = new System.Drawing.Point(186, 35);
            this.chartProducts.Name = "chartProducts";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Proizvodi";
            this.chartProducts.Series.Add(series3);
            this.helpProvider1.SetShowHelp(this.chartProducts, true);
            this.chartProducts.Size = new System.Drawing.Size(677, 511);
            this.chartProducts.TabIndex = 1;
            this.chartProducts.Text = "chartProducts";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 543);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Povratak";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmGrafickiPrikazInventara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 578);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartProducts);
            this.Name = "FrmGrafickiPrikazInventara";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Grafički prikaz stanja inventara";
            this.Load += new System.EventHandler(this.FrmGrafickiPrikazInventara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnBack;
    }
}