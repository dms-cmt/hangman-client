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

			int[] args;
			args = client.PokreniIgru ();
			ukupanBrojSlova = client.PokreniIgru ()[0];
			txtGlavna.Text = "";
			for (int i = 0, j = 1; i < ukupanBrojSlova; i++)
			{
				if (j < args.Count () && args [j] == i)
				{
					j++;
					txtGlavna.Text += " ";
					continue;
				}
				txtGlavna.Text += "_";
			}

			PrikaziZivot ();
        }

        private void SlovoClick(object sender, EventArgs e)
        {
			Button pozivalac = (Button)sender;
			OsveziTekst(pozivalac.Text);
			pozivalac.Enabled = false;
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
			PictureBox cicaglisa;
			int brojPokusaja = client.BrojPokusaja ();
			string[] zivoti = { 
					"picGlava",
					"pictureBox1", 
					"pictureBox3",
					"pictureBox4",
					"pictureBox5",
					"pictureBox6"
				};
			for (int i = 0; i < 6; i++)
			{
				cicaglisa = (PictureBox)Controls.Find (zivoti[i], true) [0];
				if (i < brojPokusaja)
					cicaglisa.Visible = true;
				else
					cicaglisa.Visible = false;
			}
		}
    }
}
