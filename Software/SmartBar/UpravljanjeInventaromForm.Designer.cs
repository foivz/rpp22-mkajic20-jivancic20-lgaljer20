namespace SmartBar
{
    partial class UpravljanjeInventaromForm
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
            this.dgvInventar = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventar
            // 
            this.dgvInventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventar.Location = new System.Drawing.Point(12, 12);
            this.dgvInventar.Name = "dgvInventar";
            this.dgvInventar.Size = new System.Drawing.Size(891, 398);
            this.dgvInventar.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(713, 416);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Kreiraj";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // UpravljanjeInventaromForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvInventar);
            this.Name = "UpravljanjeInventaromForm";
            this.Text = "Upravljanje Inventarom";
            this.Load += new System.EventHandler(this.UpravljanjeInventaromForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventar;
        private System.Windows.Forms.Button btnCreate;
    }
}