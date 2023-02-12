namespace SmartBar
{
    partial class FrmPrimka
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
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.btnNovaPrimka = new System.Windows.Forms.Button();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.btnAddStavka = new System.Windows.Forms.Button();
            this.btnDeleteStavka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrimke
            // 
            this.dgvPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimke.Location = new System.Drawing.Point(12, 21);
            this.dgvPrimke.Name = "dgvPrimke";
            this.dgvPrimke.RowHeadersWidth = 51;
            this.dgvPrimke.RowTemplate.Height = 24;
            this.dgvPrimke.Size = new System.Drawing.Size(600, 195);
            this.dgvPrimke.TabIndex = 0;
            // 
            // btnNovaPrimka
            // 
            this.btnNovaPrimka.Location = new System.Drawing.Point(665, 193);
            this.btnNovaPrimka.Name = "btnNovaPrimka";
            this.btnNovaPrimka.Size = new System.Drawing.Size(120, 23);
            this.btnNovaPrimka.TabIndex = 1;
            this.btnNovaPrimka.Text = "Nova primka";
            this.btnNovaPrimka.UseVisualStyleBackColor = true;
            this.btnNovaPrimka.Click += new System.EventHandler(this.btnNovaPrimka_Click);
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(12, 262);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.RowHeadersWidth = 51;
            this.dgvStavkePrimke.RowTemplate.Height = 24;
            this.dgvStavkePrimke.Size = new System.Drawing.Size(600, 195);
            this.dgvStavkePrimke.TabIndex = 2;
            // 
            // btnAddStavka
            // 
            this.btnAddStavka.Location = new System.Drawing.Point(665, 380);
            this.btnAddStavka.Name = "btnAddStavka";
            this.btnAddStavka.Size = new System.Drawing.Size(120, 23);
            this.btnAddStavka.TabIndex = 3;
            this.btnAddStavka.Text = "Dodaj stavku";
            this.btnAddStavka.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStavka
            // 
            this.btnDeleteStavka.Location = new System.Drawing.Point(665, 434);
            this.btnDeleteStavka.Name = "btnDeleteStavka";
            this.btnDeleteStavka.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteStavka.TabIndex = 4;
            this.btnDeleteStavka.Text = "Obriši stavku";
            this.btnDeleteStavka.UseVisualStyleBackColor = true;
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 476);
            this.Controls.Add(this.btnDeleteStavka);
            this.Controls.Add(this.btnAddStavka);
            this.Controls.Add(this.dgvStavkePrimke);
            this.Controls.Add(this.btnNovaPrimka);
            this.Controls.Add(this.dgvPrimke);
            this.Name = "FrmPrimka";
            this.Text = "Primke";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.Button btnNovaPrimka;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.Button btnAddStavka;
        private System.Windows.Forms.Button btnDeleteStavka;
    }
}