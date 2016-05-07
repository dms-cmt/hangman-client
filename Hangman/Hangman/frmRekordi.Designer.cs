namespace Hangman
{
    partial class frmRekordi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRekordi));
            this.lblRekordi = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.AnimacijaU = new System.Windows.Forms.Timer(this.components);
            this.AnimacijaIz = new System.Windows.Forms.Timer(this.components);
            this.dataRekordi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataRekordi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRekordi
            // 
            this.lblRekordi.AutoSize = true;
            this.lblRekordi.BackColor = System.Drawing.Color.Transparent;
            this.lblRekordi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekordi.Location = new System.Drawing.Point(216, 188);
            this.lblRekordi.Name = "lblRekordi";
            this.lblRekordi.Size = new System.Drawing.Size(74, 23);
            this.lblRekordi.TabIndex = 3;
            this.lblRekordi.Text = "Rekordi";
            this.lblRekordi.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 407);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(123, 29);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnZapocni_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvezi.Location = new System.Drawing.Point(220, 407);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(123, 29);
            this.btnOsvezi.TabIndex = 6;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = false;
			this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // AnimacijaU
            // 
            this.AnimacijaU.Enabled = true;
            this.AnimacijaU.Interval = 1;
            this.AnimacijaU.Tick += new System.EventHandler(this.AnimacijaU_Tick);
            // 
            // AnimacijaIz
            // 
            this.AnimacijaIz.Interval = 1;
            this.AnimacijaIz.Tick += new System.EventHandler(this.AnimacijaIz_Tick);
            // 
            // dataRekordi
            // 
            this.dataRekordi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataRekordi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRekordi.Location = new System.Drawing.Point(220, 214);
            this.dataRekordi.Name = "dataRekordi";
            this.dataRekordi.Size = new System.Drawing.Size(122, 187);
            this.dataRekordi.TabIndex = 17;
            // 
            // frmRekordi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.Controls.Add(this.dataRekordi);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblRekordi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRekordi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vešalice (ALPHA)";
            this.Load += new System.EventHandler(this.frmRekordi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRekordi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRekordi;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Timer AnimacijaU;
        private System.Windows.Forms.Timer AnimacijaIz;
        private System.Windows.Forms.DataGridView dataRekordi;
    }
}