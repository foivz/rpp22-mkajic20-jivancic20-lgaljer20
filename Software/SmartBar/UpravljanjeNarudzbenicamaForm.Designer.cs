namespace SmartBar
{
    partial class UpravljanjeNarudzbenicamaForm
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
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(12, 12);
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.Size = new System.Drawing.Size(776, 383);
            this.dgvNarudzbenice.TabIndex = 0;
            this.dgvNarudzbenice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbenice_CellClick);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(664, 401);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(124, 37);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 37);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Povratak";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpravljanjeNarudzbenicamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvNarudzbenice);
            this.Name = "UpravljanjeNarudzbenicamaForm";
            this.Text = "UpravljanjeNarudzbenicamaForm";
            this.Load += new System.EventHandler(this.UpravljanjeNarudzbenicamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnBack;
    }
}