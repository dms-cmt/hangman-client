namespace Hangman
{
    partial class frmO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmO));
            this.lblAutori = new System.Windows.Forms.Label();
            this.lblProjekat = new System.Windows.Forms.Label();
            this.linkAdresa = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.AnimacijaU = new System.Windows.Forms.Timer(this.components);
            this.AnimacijaIz = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAutori
            // 
            this.lblAutori.AutoSize = true;
            this.lblAutori.BackColor = System.Drawing.Color.Transparent;
            this.lblAutori.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutori.Location = new System.Drawing.Point(212, 184);
            this.lblAutori.Name = "lblAutori";
            this.lblAutori.Size = new System.Drawing.Size(128, 69);
            this.lblAutori.TabIndex = 9;
            this.lblAutori.Text = "Autori:\r\nĐorđe Gluvajić\r\nMiloš Zivlak";
            // 
            // lblProjekat
            // 
            this.lblProjekat.AutoSize = true;
            this.lblProjekat.BackColor = System.Drawing.Color.Transparent;
            this.lblProjekat.Location = new System.Drawing.Point(112, 264);
            this.lblProjekat.Name = "lblProjekat";
            this.lblProjekat.Size = new System.Drawing.Size(237, 78);
            this.lblProjekat.TabIndex = 11;
            this.lblProjekat.Text = "Ovo je projekat napravljen za K4 kurs \"Center za\r\nmlade talente\" Novi Sad. \r\nLink" +
                ":\r\n\r\nKlijent aplikacija (v1.00) rađena u\r\nC# (Visual Studio 2010).";
            // 
            // linkAdresa
            // 
            this.linkAdresa.AutoSize = true;
            this.linkAdresa.Location = new System.Drawing.Point(140, 290);
            this.linkAdresa.Name = "linkAdresa";
            this.linkAdresa.Size = new System.Drawing.Size(83, 13);
            this.linkAdresa.TabIndex = 13;
            this.linkAdresa.TabStop = true;
            this.linkAdresa.Text = "www.cmt.edu.rs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(308, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "v1.00";
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Batang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 407);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(123, 29);
            this.btnNazad.TabIndex = 15;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnZapocni_Click);
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
            // frmO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkAdresa);
            this.Controls.Add(this.lblProjekat);
            this.Controls.Add(this.lblAutori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vešalice (PRE-ALPHA)";
            this.Load += new System.EventHandler(this.frmO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutori;
        private System.Windows.Forms.Label lblProjekat;
        private System.Windows.Forms.LinkLabel linkAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Timer AnimacijaU;
        private System.Windows.Forms.Timer AnimacijaIz;
    }
}