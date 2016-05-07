namespace Hangman
{
    partial class frmIgra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIgra));
            this.txtGlavna = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.btnChi = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.brnE = new System.Windows.Forms.Button();
            this.btnDj = new System.Windows.Forms.Button();
            this.btnDz = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnNj = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnLj = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnZh = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnSh = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPreostaloVreme = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPonovnaIgra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picGlava = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGlavna
            // 
            this.txtGlavna.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlavna.Location = new System.Drawing.Point(-1, 292);
            this.txtGlavna.Name = "txtGlavna";
            this.txtGlavna.ReadOnly = true;
            this.txtGlavna.Size = new System.Drawing.Size(356, 37);
            this.txtGlavna.TabIndex = 0;
            this.txtGlavna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(13, 11);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(32, 32);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
			this.btnA.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(46, 11);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(32, 32);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
			this.btnB.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(79, 11);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(32, 32);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
			this.btnC.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnCh
            // 
            this.btnCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCh.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCh.Location = new System.Drawing.Point(112, 11);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(32, 32);
            this.btnCh.TabIndex = 4;
            this.btnCh.Text = "Č";
            this.btnCh.UseVisualStyleBackColor = false;
			this.btnCh.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnChi
            // 
            this.btnChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChi.Location = new System.Drawing.Point(145, 11);
            this.btnChi.Name = "btnChi";
            this.btnChi.Size = new System.Drawing.Size(32, 32);
            this.btnChi.TabIndex = 5;
            this.btnChi.Text = "Ć";
            this.btnChi.UseVisualStyleBackColor = false;
			this.btnChi.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(310, 11);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(32, 32);
            this.btnF.TabIndex = 10;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
			this.btnF.Click += new System.EventHandler(this.SlovoClick);
            // 
            // brnE
            // 
            this.brnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.brnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnE.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnE.Location = new System.Drawing.Point(277, 11);
            this.brnE.Name = "brnE";
            this.brnE.Size = new System.Drawing.Size(32, 32);
            this.brnE.TabIndex = 9;
            this.brnE.Text = "E";
            this.brnE.UseVisualStyleBackColor = false;
			this.brnE.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnDj
            // 
            this.btnDj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDj.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDj.Location = new System.Drawing.Point(244, 11);
            this.btnDj.Name = "btnDj";
            this.btnDj.Size = new System.Drawing.Size(32, 32);
            this.btnDj.TabIndex = 8;
            this.btnDj.Text = "Đ";
            this.btnDj.UseVisualStyleBackColor = false;
			this.btnDj.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnDz
            // 
            this.btnDz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDz.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDz.Location = new System.Drawing.Point(211, 11);
            this.btnDz.Name = "btnDz";
            this.btnDz.Size = new System.Drawing.Size(32, 32);
            this.btnDz.TabIndex = 7;
            this.btnDz.Text = "Dž";
            this.btnDz.UseVisualStyleBackColor = false;
			this.btnDz.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(178, 11);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(32, 32);
            this.btnD.TabIndex = 6;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
			this.btnD.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnNj
            // 
            this.btnNj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNj.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNj.Location = new System.Drawing.Point(310, 44);
            this.btnNj.Name = "btnNj";
            this.btnNj.Size = new System.Drawing.Size(32, 32);
            this.btnNj.TabIndex = 20;
            this.btnNj.Text = "Nj";
            this.btnNj.UseVisualStyleBackColor = false;
			this.btnNj.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(277, 44);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(32, 32);
            this.btnN.TabIndex = 19;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
			this.btnN.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(244, 44);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(32, 32);
            this.btnM.TabIndex = 18;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
			this.btnM.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnLj
            // 
            this.btnLj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLj.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLj.Location = new System.Drawing.Point(211, 44);
            this.btnLj.Name = "btnLj";
            this.btnLj.Size = new System.Drawing.Size(32, 32);
            this.btnLj.TabIndex = 17;
            this.btnLj.Text = "Lj";
            this.btnLj.UseVisualStyleBackColor = false;
			this.btnLj.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(178, 44);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(32, 32);
            this.btnL.TabIndex = 16;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
			this.btnL.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(145, 44);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(32, 32);
            this.btnK.TabIndex = 15;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
			this.btnK.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(112, 44);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(32, 32);
            this.btnJ.TabIndex = 14;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
			this.btnJ.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(79, 44);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(32, 32);
            this.btnI.TabIndex = 13;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
			this.btnI.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(46, 44);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(32, 32);
            this.btnH.TabIndex = 12;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
			this.btnH.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(13, 44);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(32, 32);
            this.btnG.TabIndex = 11;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
			this.btnG.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnZh
            // 
            this.btnZh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnZh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZh.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZh.Location = new System.Drawing.Point(310, 77);
            this.btnZh.Name = "btnZh";
            this.btnZh.Size = new System.Drawing.Size(32, 32);
            this.btnZh.TabIndex = 30;
            this.btnZh.Text = "Ž";
            this.btnZh.UseVisualStyleBackColor = false;
			this.btnZh.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(277, 77);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(32, 32);
            this.btnZ.TabIndex = 29;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
			this.btnZ.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(244, 77);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(32, 32);
            this.btnV.TabIndex = 28;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
			this.btnV.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(211, 77);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(32, 32);
            this.btnU.TabIndex = 27;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
			this.btnU.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(178, 77);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(32, 32);
            this.btnT.TabIndex = 26;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
			this.btnT.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnSh
            // 
            this.btnSh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSh.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSh.Location = new System.Drawing.Point(145, 77);
            this.btnSh.Name = "btnSh";
            this.btnSh.Size = new System.Drawing.Size(32, 32);
            this.btnSh.TabIndex = 25;
            this.btnSh.Text = "Š";
            this.btnSh.UseVisualStyleBackColor = false;
			this.btnSh.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(112, 77);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(32, 32);
            this.btnS.TabIndex = 24;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
			this.btnS.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(79, 77);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(32, 32);
            this.btnR.TabIndex = 23;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
			this.btnR.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(46, 77);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(32, 32);
            this.btnP.TabIndex = 22;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
			this.btnP.Click += new System.EventHandler(this.SlovoClick);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(13, 77);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(32, 32);
            this.btnO.TabIndex = 21;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
			this.btnO.Click += new System.EventHandler(this.SlovoClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "◄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPreostaloVreme
            // 
            this.lblPreostaloVreme.AutoSize = true;
            this.lblPreostaloVreme.BackColor = System.Drawing.Color.Transparent;
            this.lblPreostaloVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreostaloVreme.Location = new System.Drawing.Point(266, 29);
            this.lblPreostaloVreme.Name = "lblPreostaloVreme";
            this.lblPreostaloVreme.Size = new System.Drawing.Size(45, 24);
            this.lblPreostaloVreme.TabIndex = 32;
            this.lblPreostaloVreme.Text = "3:00";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.BackColor = System.Drawing.Color.Transparent;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(281, 246);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(60, 24);
            this.lblPoeni.TabIndex = 33;
            this.lblPoeni.Text = "12320";
            this.lblPoeni.Click += new System.EventHandler(this.lblPoeni_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(309, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btnPonovnaIgra
            // 
            this.btnPonovnaIgra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPonovnaIgra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonovnaIgra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonovnaIgra.Image = ((System.Drawing.Image)(resources.GetObject("btnPonovnaIgra.Image")));
            this.btnPonovnaIgra.Location = new System.Drawing.Point(12, 254);
            this.btnPonovnaIgra.Name = "btnPonovnaIgra";
            this.btnPonovnaIgra.Size = new System.Drawing.Size(32, 32);
            this.btnPonovnaIgra.TabIndex = 36;
            this.btnPonovnaIgra.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNj);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnCh);
            this.panel1.Controls.Add(this.btnChi);
            this.panel1.Controls.Add(this.btnZh);
            this.panel1.Controls.Add(this.btnD);
            this.panel1.Controls.Add(this.btnZ);
            this.panel1.Controls.Add(this.btnDz);
            this.panel1.Controls.Add(this.btnV);
            this.panel1.Controls.Add(this.btnDj);
            this.panel1.Controls.Add(this.btnU);
            this.panel1.Controls.Add(this.brnE);
            this.panel1.Controls.Add(this.btnT);
            this.panel1.Controls.Add(this.btnF);
            this.panel1.Controls.Add(this.btnSh);
            this.panel1.Controls.Add(this.btnG);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnH);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.btnI);
            this.panel1.Controls.Add(this.btnP);
            this.panel1.Controls.Add(this.btnJ);
            this.panel1.Controls.Add(this.btnO);
            this.panel1.Controls.Add(this.btnK);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnN);
            this.panel1.Controls.Add(this.btnLj);
            this.panel1.Controls.Add(this.btnM);
            this.panel1.Location = new System.Drawing.Point(-1, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 129);
            this.panel1.TabIndex = 37;
            // 
            // picGlava
            // 
            this.picGlava.BackColor = System.Drawing.Color.Transparent;
            this.picGlava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGlava.BackgroundImage")));
            this.picGlava.Location = new System.Drawing.Point(145, 28);
            this.picGlava.Name = "picGlava";
            this.picGlava.Size = new System.Drawing.Size(75, 77);
            this.picGlava.TabIndex = 38;
            this.picGlava.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 86);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(194, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 100);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(93, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(82, 100);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(185, 186);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 88);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(105, 186);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 88);
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // frmIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picGlava);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPonovnaIgra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.lblPreostaloVreme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGlavna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIgra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vešalice (ALPHA)";
            this.Load += new System.EventHandler(this.frmIgra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGlavna;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.Button btnChi;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button brnE;
        private System.Windows.Forms.Button btnDj;
        private System.Windows.Forms.Button btnDz;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnNj;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnLj;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnZh;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnSh;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPreostaloVreme;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPonovnaIgra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picGlava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;

    }
}