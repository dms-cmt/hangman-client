using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmO : Form
    {
        private int X, Y;
        public frmO(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            this.Location = new Point(X, Y);
            InitializeComponent();
        }

        private void frmO_Load(object sender, EventArgs e)
        {
            lblAutori.Location = new Point(lblAutori.Location.X + 200, lblAutori.Location.Y);
            lblProjekat.Location = new Point(lblProjekat.Location.X + 400, lblProjekat.Location.Y);
            linkAdresa.Location = new Point(linkAdresa.Location.X + 400, linkAdresa.Location.Y);
            btnNazad.Location = new Point(btnNazad.Location.X - 200, btnNazad.Location.Y);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            frmGlavna f = new frmGlavna(this.Location.X, this.Location.Y);
            f.Show();
            this.Hide();
        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            AnimacijaU.Stop();
            AnimacijaIz.Start();
        }

        private void AnimacijaU_Tick(object sender, EventArgs e)
        {
            if (lblAutori.Location.X != 212)
            {
                lblAutori.Location = new Point(lblAutori.Location.X - 4, lblAutori.Location.Y);
            }

            if (lblProjekat.Location.X != 112)
            {
                lblProjekat.Location = new Point(lblProjekat.Location.X - 4, lblProjekat.Location.Y);
            }

            if (linkAdresa.Location.X != 140)
            {
                linkAdresa.Location = new Point(linkAdresa.Location.X - 4, linkAdresa.Location.Y);
            }

            if (btnNazad.Location.X != 12)
            {
                btnNazad.Location = new Point(btnNazad.Location.X + 4, btnNazad.Location.Y);
            }
        }

        private void AnimacijaIz_Tick(object sender, EventArgs e)
        {
            if (btnNazad.Location.X != -208)
            {
                btnNazad.Location = new Point(btnNazad.Location.X - 5, btnNazad.Location.Y);
                lblAutori.Location = new Point(lblAutori.Location.X + 5, lblAutori.Location.Y);
                linkAdresa.Location = new Point(linkAdresa.Location.X + 5, linkAdresa.Location.Y);
                lblProjekat.Location = new Point(lblProjekat.Location.X + 5, lblProjekat.Location.Y);
            }
            else
            {
                AnimacijaIz.Stop();
                frmGlavna f = new frmGlavna(this.Location.X, this.Location.Y);
                f.Show();
                this.Hide();
            }
            
        }
    }
}
