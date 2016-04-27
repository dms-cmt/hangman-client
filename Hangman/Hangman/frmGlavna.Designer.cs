namespace Hangman
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.btnZapocni = new System.Windows.Forms.Button();
            this.btnRekordi = new System.Windows.Forms.Button();
            this.AnimacijaU = new System.Windows.Forms.Timer(this.components);
            this.btnO = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnimacijaIz = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnZapocni
            // 
            this.btnZapocni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnZapocni.Enabled = false;
            this.btnZapocni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapocni.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapocni.Location = new System.Drawing.Point(220, 208);
            this.btnZapocni.Name = "btnZapocni";
            this.btnZapocni.Size = new System.Drawing.Size(123, 29);
            this.btnZapocni.TabIndex = 0;
            this.btnZapocni.Text = "Započni igru";
            this.btnZapocni.UseVisualStyleBackColor = false;
            this.btnZapocni.Click += new System.EventHandler(this.btnZapocni_Click);
            // 
            // btnRekordi
            // 
            this.btnRekordi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRekordi.Enabled = false;
            this.btnRekordi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekordi.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekordi.Location = new System.Drawing.Point(220, 250);
            this.btnRekordi.Name = "btnRekordi";
            this.btnRekordi.Size = new System.Drawing.Size(123, 29);
            this.btnRekordi.TabIndex = 1;
            this.btnRekordi.Text = "Rekordi";
            this.btnRekordi.UseVisualStyleBackColor = false;
            this.btnRekordi.Click += new System.EventHandler(this.btnRekordi_Click);
            // 
            // AnimacijaU
            // 
            this.AnimacijaU.Enabled = true;
            this.AnimacijaU.Interval = 1;
            this.AnimacijaU.Tick += new System.EventHandler(this.AnimacijaU_Tick);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnO.Enabled = false;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(220, 292);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(123, 29);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "O igri...";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIzadji.Enabled = false;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(220, 348);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(123, 29);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izađi iz igre";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(308, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "v1.00";
            // 
            // AnimacijaIz
            // 
            this.AnimacijaIz.Interval = 1;
            this.AnimacijaIz.Tick += new System.EventHandler(this.AnimacijaIz_Tick);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnRekordi);
            this.Controls.Add(this.btnZapocni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vešalice (ALPHA)";
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapocni;
        private System.Windows.Forms.Button btnRekordi;
        private System.Windows.Forms.Timer AnimacijaU;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer AnimacijaIz;

    }
}

