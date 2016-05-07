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
			if (client == null)
				return;
				
			List<int> indeksi = client.Provera (Text.ToCharArray ());
			char[] chGlavna = txtGlavna.Text.ToCharArray ();

			txtGlavna.Text = "";
			if (indeksi.Count > 0)
			{
				for (int i = 0, j = 0, k = 0; i < chGlavna.Length; i++)
				{
					if (Char.IsLower (chGlavna [i]))
					{
						txtGlavna.Text += chGlavna [i];
						k++;
						continue;
					}
					if (j < indeksi.Count && (i - k) == indeksi [j])
					{
						j++;
						txtGlavna.Text += Text;
					} else
					{
						txtGlavna.Text += chGlavna [i];
					}
				}
			}

			PrikaziZivot ();
			EStatusIgre status = client.Status ();
			if (status == EStatusIgre.IGRA_ZAVRSENA_POBEDA)
			{
				Timer.Stop ();
				frmUnosRekorda dialog = new frmUnosRekorda (client);
				dialog.ShowDialog ();
				frmGlavna f = new frmGlavna (this.Location.X, this.Location.Y);
				Close ();
				f.Show ();
			} else if (status == EStatusIgre.IGRA_ZAVRSENA_PORAZ)
			{
				Timer.Stop ();
				txtGlavna.Text = client.Resenje ().ToString ();
				txtGlavna.Text = "";
				char[] ca = client.Resenje ();
				foreach (char c in ca)
					txtGlavna.Text += c;
			}
        }

        private void frmIgra_Load(object sender, EventArgs e)
        {
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

			Timer.Start ();
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
			if (client.Status () == EStatusIgre.IGRA_AKTIVNA)
			{
				if (MessageBox.Show ("Da li ste sigurni da zelite da zavrsite ovu partiju?", "Izlazak iz partije", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string resejne = new string (client.Resenje ());
					OsveziTekst (resejne);
				} else
					return;
			}

			if (MessageBox.Show ("Da li ste sigurni da zelite da izadjete iz igre.", "Povratak na prethodni meni", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				frmGlavna f = new frmGlavna (this.Location.X, this.Location.Y);
				this.Close ();
				f.Show ();
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
			long vreme;
			long h, m, s;

			vreme = client.Vreme ();
			m = vreme / 60;
			s = vreme % 60;
			lblPreostaloVreme.Text = m.ToString () + ":" + s.ToString ();
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
