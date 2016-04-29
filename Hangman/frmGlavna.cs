using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using HangmanService;

namespace Hangman
{
    public partial class frmGlavna : Form
    {
        private static int Destinacija { get; set; }
        private int X, Y;

		// Objekat za komunikaciju sa servisom
		HangmanClient client;

        public frmGlavna(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            if(X != 0)
            {
                this.Location = new Point(X, Y);
            }
            InitializeComponent();

			// Konekcija na servis
			Connect ();
        }

        private void pbZapocni_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmRekordi f = new frmRekordi(this.Location.X, this.Location.Y);
            f.Show();
            this.Hide();
        }

        private void pbO_Click(object sender, EventArgs e)
        {
            frmO f = new frmO(this.Location.X, this.Location.Y);
            f.Show();
            this.Hide();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            btnZapocni.Location = new Point(btnZapocni.Location.X + 200, btnZapocni.Location.Y);
            btnRekordi.Location = new Point(btnRekordi.Location.X + 280, btnRekordi.Location.Y);
            btnO.Location = new Point(btnO.Location.X + 360, btnO.Location.Y);
            btnIzadji.Location = new Point(btnIzadji.Location.X + 440, btnIzadji.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Destinacija = 3;
            AnimacijaU.Stop();
            AnimacijaIz.Start();
        }

        private void AnimacijaU_Tick(object sender, EventArgs e)
        {
            if (btnZapocni.Location.X != 220)
            {
                btnZapocni.Location = new Point(btnZapocni.Location.X - 5, btnZapocni.Location.Y);
            } else {
                btnZapocni.Enabled = true;
            }

            if (btnIzadji.Location.X != 220)
            {
                btnIzadji.Location = new Point(btnIzadji.Location.X - 5, btnIzadji.Location.Y);
            } else {
                btnIzadji.Enabled = true;
            }

            if (btnO.Location.X != 220)
            {
                btnO.Location = new Point(btnO.Location.X - 5, btnO.Location.Y);
            } else {
                btnO.Enabled = true;
            }

            if (btnRekordi.Location.X != 220)
            {
                btnRekordi.Location = new Point(btnRekordi.Location.X - 5, btnRekordi.Location.Y);
            } else {
                btnRekordi.Enabled = true;
            }
        }

        private void AnimacijaIz_Tick(object sender, EventArgs e)
        {
            if (btnZapocni.Location.X < 400)
            {
                btnZapocni.Location = new Point(btnZapocni.Location.X + 5, btnZapocni.Location.Y);
                btnIzadji.Location = new Point(btnIzadji.Location.X + 5, btnIzadji.Location.Y);
                btnO.Location = new Point(btnO.Location.X + 5, btnO.Location.Y);
                btnRekordi.Location = new Point(btnRekordi.Location.X + 5, btnRekordi.Location.Y);
            } else {
                btnZapocni.Enabled = false;
                btnIzadji.Enabled = false;
                btnO.Enabled = false;
                btnRekordi.Enabled = false;
                AnimacijaIz.Stop();
                switch(Destinacija)
                {
                    case 1:
                        frmIgra g = new frmIgra(this.Location.X, this.Location.Y, client);
                        g.Show();
                        this.Hide();
                        break;
                    case 2:
                        frmRekordi r = new frmRekordi(this.Location.X, this.Location.Y, client);
                        r.Show();
                        this.Hide();
                        break;
                    case 3:
                        frmO o = new frmO(this.Location.X, this.Location.Y);
                        o.Show();
                        this.Hide();
                        break;
                }
            }
        }

        private void btnRekordi_Click(object sender, EventArgs e)
        {
            Destinacija = 2;
            AnimacijaU.Stop();
            AnimacijaIz.Start();
        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            Destinacija = 1;
            AnimacijaU.Stop();
            AnimacijaIz.Start();
        }

		/*
		 * Otvaranje konekcije na servis
		 */
		private void Connect ()
		{
			var security = new SecurityMode ();
			var binding = new WSHttpBinding (security, true);
			var address = new EndpointAddress ("http://dms-cmt.ddns.net:8325/");
			client = new HangmanClient (binding, address);
		}
    }
}
