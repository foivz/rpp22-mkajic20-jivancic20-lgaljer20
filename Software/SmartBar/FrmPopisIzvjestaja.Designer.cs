namespace SmartBar
{
    partial class FrmPopisIzvjestaja
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
            this.dgIzvjestaji = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgIzvjestaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgIzvjestaji
            // 
            this.dgIzvjestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIzvjestaji.Location = new System.Drawing.Point(23, 26);
            this.dgIzvjestaji.Name = "dgIzvjestaji";
            this.dgIzvjestaji.RowHeadersWidth = 51;
            this.dgIzvjestaji.RowTemplate.Height = 24;
            this.dgIzvjestaji.Size = new System.Drawing.Size(474, 230);
            this.dgIzvjestaji.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(297, 268);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 31);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Pregledaj";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(387, 268);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(84, 31);
            this.btnGeneriraj.TabIndex = 2;
            this.btnGeneriraj.Text = "Generiraj";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventurni zapisnici:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Povratak";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmPopisIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 311);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgIzvjestaji);
            this.Name = "FrmPopisIzvjestaja";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Popis inventurnih zapisnika";
            this.Load += new System.EventHandler(this.FrmPopisIzvjestaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIzvjestaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgIzvjestaji;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnBack;
    }
}