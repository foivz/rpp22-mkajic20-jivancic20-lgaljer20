namespace SmartBar
{
    partial class FrmUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceipts = new System.Windows.Forms.Button();
            this.btnGraf = new System.Windows.Forms.Button();
            this.btnPrimke = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijavljeni ste kao korisnik";
            // 
            // btnReceipts
            // 
            this.btnReceipts.Location = new System.Drawing.Point(11, 45);
            this.btnReceipts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.Size = new System.Drawing.Size(72, 23);
            this.btnReceipts.TabIndex = 1;
            this.btnReceipts.Text = "Računi";
            this.btnReceipts.UseVisualStyleBackColor = true;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // btnGraf
            // 
            this.btnGraf.Location = new System.Drawing.Point(122, 39);
            this.btnGraf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(83, 37);
            this.btnGraf.TabIndex = 2;
            this.btnGraf.Text = "Grafički prikaz inventara";
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Click += new System.EventHandler(this.btnGraf_Click);
            // 
            // btnPrimke
            // 
            this.btnPrimke.Location = new System.Drawing.Point(239, 39);
            this.btnPrimke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrimke.Name = "btnPrimke";
            this.btnPrimke.Size = new System.Drawing.Size(83, 34);
            this.btnPrimke.TabIndex = 3;
            this.btnPrimke.Text = "Popis primki";
            this.btnPrimke.UseVisualStyleBackColor = true;
            this.btnPrimke.Click += new System.EventHandler(this.btnPrimke_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(79, 199);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPrimke);
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.btnReceipts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUser";
            this.Text = "SmartBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceipts;
        private System.Windows.Forms.Button btnGraf;
        private System.Windows.Forms.Button btnPrimke;
        private System.Windows.Forms.Button btnLogout;
    }
}