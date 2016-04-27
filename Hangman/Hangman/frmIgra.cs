using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HangmanService;

namespace Hangman
{
    public partial class frmIgra : Form
    {
        private int X, Y;
		private HangmanClient client;
		private int ukupanBrojSlova;

		public frmIgra(int X, int Y, HangmanClient client = null)
        {
            this.X = X;
            this.Y = Y;
            this.Location = new Point(X, Y);
			this.client = client;
            InitializeComponent();
        }
        private void OsveziTekst(String Text) //OVO JE GLAVNI LOOP ZA IGRU... TREBALO BI
        {
            //txtGlavna.Text += Text;

			if (client == null)
				return;
				
			List<int> indeksi = client.Provera (Text.ToCharArray ());
			if (indeksi.Count > 0)
			{
				char[] test = txtGlavna.Text.ToCharArray ();
				foreach (int index in indeksi)
					test [index] = Text.ToCharArray () [0];
				txtGlavna.Text = new string (test);
			}

			PrikaziZivot ();
        }

        private void frmIgra_Load(object sender, EventArgs e)
        {
            //Konekcija na bazu podataka

			ukupanBrojSlova = client.PokreniIgru ();
			txtGlavna.Text = "";
			for (int i = 0; i < ukupanBrojSlova; i++)
				txtGlavna.Text += "_";

			PrikaziZivot ();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            OsveziTekst("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            OsveziTekst("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            OsveziTekst("C");
        }

        private void btnCh_Click(object sender, EventArgs e)
        {
            OsveziTekst("Č");
        }

        private void btnChi_Click(object sender, EventArgs e)
        {
            OsveziTekst("Ć");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            OsveziTekst("D");
        }

        private void btnDz_Click(object sender, EventArgs e)
        {
            OsveziTekst("Dž");
        }

        private void btnDj_Click(object sender, EventArgs e)
        {
            OsveziTekst("Đ");
        }

        private void brnE_Click(object sender, EventArgs e)
        {
            OsveziTekst("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            OsveziTekst("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            OsveziTekst("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            OsveziTekst("H");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            OsveziTekst("I");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            OsveziTekst("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            OsveziTekst("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            OsveziTekst("L");
        }

        private void btnLj_Click(object sender, EventArgs e)
        {
            OsveziTekst("Lj");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            OsveziTekst("M");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            OsveziTekst("N");
        }

        private void btnNj_Click(object sender, EventArgs e)
        {
            OsveziTekst("Nj");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            OsveziTekst("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            OsveziTekst("P");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            OsveziTekst("R");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            OsveziTekst("S");
        }

        private void btnSh_Click(object sender, EventArgs e)
        {
            OsveziTekst("Š");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            OsveziTekst("T");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            OsveziTekst("U");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            OsveziTekst("V");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            OsveziTekst("Z");
        }

        private void btnZh_Click(object sender, EventArgs e)
        {
            OsveziTekst("Ž");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da zavrsite ovu partiju?", "Izlazak iz partije", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //sacuvavanje rekorda u bazu
            }
        }

        private void lblPoeni_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //lblTimer vreme --
            //Ako je lblTimer dosao do nule kraj je igre... postavljanje rekorda u bazu

			/*
			 * Vreme se racuna na serveru (za celokupnu igru)
			 * ako zelis dodatno da pises vreme mozes to uraditi ovako
			 * ili da napravim kao serverside
			 */
        }

		private void PrikaziZivot()
		{
			int brojPokusaja = client.BrojPokusaja ();
			for (int i = 0; i < 6; i++)
			{
				int j = i + 1;
				if (j == 2)
					j++;
				PictureBox cicaglisa = (PictureBox)Controls.Find ("pictureBox" + j.ToString (), true)[0];
				if (i < brojPokusaja)
					cicaglisa.Visible = true;
				else
					cicaglisa.Visible = false;
			}
		}
    }
}
