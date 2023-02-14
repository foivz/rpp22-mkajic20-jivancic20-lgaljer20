namespace SmartBar
{
    partial class FrmPopisPrimki
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
            this.dgNarudzbenice = new System.Windows.Forms.DataGridView();
            this.btnAutomatski = new System.Windows.Forms.Button();
            this.btnRučno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNarudzbenice
            // 
            this.dgNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNarudzbenice.Location = new System.Drawing.Point(39, 27);
            this.dgNarudzbenice.Name = "dgNarudzbenice";
            this.dgNarudzbenice.RowHeadersWidth = 51;
            this.dgNarudzbenice.RowTemplate.Height = 24;
            this.dgNarudzbenice.Size = new System.Drawing.Size(600, 230);
            this.dgNarudzbenice.TabIndex = 0;
            // 
            // btnAutomatski
            // 
            this.btnAutomatski.Location = new System.Drawing.Point(387, 287);
            this.btnAutomatski.Name = "btnAutomatski";
            this.btnAutomatski.Size = new System.Drawing.Size(123, 71);
            this.btnAutomatski.TabIndex = 1;
            this.btnAutomatski.Text = "Automatsko generiranje primke";
            this.btnAutomatski.UseVisualStyleBackColor = true;
            this.btnAutomatski.Click += new System.EventHandler(this.btnAutomatski_Click);
            // 
            // btnRučno
            // 
            this.btnRučno.Location = new System.Drawing.Point(516, 287);
            this.btnRučno.Name = "btnRučno";
            this.btnRučno.Size = new System.Drawing.Size(123, 71);
            this.btnRučno.TabIndex = 2;
            this.btnRučno.Text = "Ručno kreiranje primke";
            this.btnRučno.UseVisualStyleBackColor = true;
            this.btnRučno.Click += new System.EventHandler(this.btnRučno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis narudžbenica:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Povratak";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmPopisPrimki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 391);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRučno);
            this.Controls.Add(this.btnAutomatski);
            this.Controls.Add(this.dgNarudzbenice);
            this.Name = "FrmPopisPrimki";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Popis primki";
            this.Load += new System.EventHandler(this.FrmPopisPrimki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNarudzbenice;
        private System.Windows.Forms.Button btnAutomatski;
        private System.Windows.Forms.Button btnRučno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnBack;
    }
}