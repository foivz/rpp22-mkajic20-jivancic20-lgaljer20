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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzbrišiPrimku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnNovaPrimka.Location = new System.Drawing.Point(35, 109);
            this.btnNovaPrimka.Name = "btnNovaPrimka";
            this.btnNovaPrimka.Size = new System.Drawing.Size(132, 32);
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
            this.btnAddStavka.Location = new System.Drawing.Point(685, 375);
            this.btnAddStavka.Name = "btnAddStavka";
            this.btnAddStavka.Size = new System.Drawing.Size(132, 32);
            this.btnAddStavka.TabIndex = 3;
            this.btnAddStavka.Text = "Dodaj stavku";
            this.btnAddStavka.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStavka
            // 
            this.btnDeleteStavka.Location = new System.Drawing.Point(685, 425);
            this.btnDeleteStavka.Name = "btnDeleteStavka";
            this.btnDeleteStavka.Size = new System.Drawing.Size(132, 32);
            this.btnDeleteStavka.TabIndex = 4;
            this.btnDeleteStavka.Text = "Obriši stavku";
            this.btnDeleteStavka.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrišiPrimku);
            this.groupBox1.Controls.Add(this.cmbSuppliers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNovaPrimka);
            this.groupBox1.Location = new System.Drawing.Point(650, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova primka";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3"});
            this.cmbSuppliers.Location = new System.Drawing.Point(35, 58);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(121, 24);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite dobavljača: ";
            // 
            // btnIzbrišiPrimku
            // 
            this.btnIzbrišiPrimku.Location = new System.Drawing.Point(35, 166);
            this.btnIzbrišiPrimku.Name = "btnIzbrišiPrimku";
            this.btnIzbrišiPrimku.Size = new System.Drawing.Size(132, 32);
            this.btnIzbrišiPrimku.TabIndex = 4;
            this.btnIzbrišiPrimku.Text = "Izbriši primku";
            this.btnIzbrišiPrimku.UseVisualStyleBackColor = true;
            this.btnIzbrišiPrimku.Click += new System.EventHandler(this.btnIzbrišiPrimku_Click);
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteStavka);
            this.Controls.Add(this.btnAddStavka);
            this.Controls.Add(this.dgvStavkePrimke);
            this.Controls.Add(this.dgvPrimke);
            this.Name = "FrmPrimka";
            this.Text = "Primke";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.Button btnNovaPrimka;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.Button btnAddStavka;
        private System.Windows.Forms.Button btnDeleteStavka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrišiPrimku;
    }
}