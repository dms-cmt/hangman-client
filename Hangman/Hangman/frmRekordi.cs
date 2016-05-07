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
    public partial class frmRekordi : Form
    {
        private int X, Y;
		// Objekat za komunikaciju sa servisom
		private HangmanClient client;

		public frmRekordi(int X, int Y, HangmanClient client = null)
        {
            this.X = X;
            this.Y = Y;
            this.Location = new Point(X, Y);
			this.client = client;
            InitializeComponent();
        }

        private void lblGreska_Click(object sender, EventArgs e)
        {

        }

        private void pbNazad_Click(object sender, EventArgs e)
        {
            frmGlavna f = new frmGlavna(this.Location.X, this.Location.Y);
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            AnimacijaU.Stop();
            AnimacijaIz.Start();
        }

		private void btnOsvezi_Click(object sender, EventArgs e)
		{
			PreuzmiRekorde ();
		}

        private void frmRekordi_Load(object sender, EventArgs e)
        {
            /* DA SE NE BI MUCIO SA GOMILU LABEL-OVA POSTAVIO SAM DATA GRID VIEW STO BI TREBALO DA OLAKSA POSAO*/
            btnNazad.Location = new Point(btnNazad.Location.X - 200, btnNazad.Location.Y);
            btnOsvezi.Location = new Point(btnOsvezi.Location.X + 200, btnOsvezi.Location.Y);
            lblRekordi.Location = new Point(lblRekordi.Location.X + 300, lblRekordi.Location.Y);
            dataRekordi.Location = new Point(dataRekordi.Location.X + 400, dataRekordi.Location.Y);

			try
			{
				PreuzmiRekorde ();
			} catch (Exception ex)
			{
				MessageBox.Show ("Nema konekcije sa servisom!");
			}
        }

        private void AnimacijaU_Tick(object sender, EventArgs e)
        {
            if (btnOsvezi.Location.X != 220)
            {
                btnOsvezi.Location = new Point(btnOsvezi.Location.X - 4, btnOsvezi.Location.Y);
                btnNazad.Location = new Point(btnNazad.Location.X + 4, btnNazad.Location.Y);
            }
            if(lblRekordi.Location.X != 216)
            {
                lblRekordi.Location = new Point(lblRekordi.Location.X - 4, lblRekordi.Location.Y);
            }
            if(dataRekordi.Location.X != 220)
            {
                dataRekordi.Location = new Point(dataRekordi.Location.X - 4, dataRekordi.Location.Y);
            }
        }

        private void AnimacijaIz_Tick(object sender, EventArgs e)
        {
            if (btnNazad.Location.X != -212)
            {
                btnNazad.Location = new Point(btnNazad.Location.X - 4, btnNazad.Location.Y);
                btnOsvezi.Location = new Point(btnOsvezi.Location.X + 5, btnOsvezi.Location.Y);
                lblRekordi.Location = new Point(lblRekordi.Location.X + 5, lblRekordi.Location.Y);
                dataRekordi.Location = new Point(dataRekordi.Location.X + 5, dataRekordi.Location.Y);
            }
            else
            {
                AnimacijaIz.Stop();
                frmGlavna f = new frmGlavna(this.Location.X, this.Location.Y);
                f.Show();
                this.Hide();
            }
        }

		/**
		 * Funkcija preuzima podatke sa servisa (rekorde)
		 */
		private void PreuzmiRekorde ()
		{
			if (client == null)
				throw new Exception ("Nema konekcije sa servisom");

			dataRekordi.AutoGenerateColumns = false;
			DataGridViewCell cell = new DataGridViewTextBoxCell ();
			DataGridViewTextBoxColumn columnIme = new DataGridViewTextBoxColumn ()
			{
				CellTemplate = cell,
				Name = "ImeKorisnika",
				HeaderText = "Ime",
				DataPropertyName = "ImeKorisnika"
			};
			DataGridViewTextBoxColumn columnVreme = new DataGridViewTextBoxColumn ()
			{
				CellTemplate = cell,
				Name = "BrojSekundi",
				HeaderText = "Vreme",
				DataPropertyName = "BrojSekundi"
			};
			DataGridViewTextBoxColumn columnBrSlova = new DataGridViewTextBoxColumn ()
			{
				CellTemplate = cell,
				Name = "BrojPogresnihSlova",
				HeaderText = "Broj pogresnih slova",
				DataPropertyName = "BrojPogresnihSlova"
			};
			dataRekordi.Columns.Add (columnIme);
			dataRekordi.Columns.Add (columnVreme);
			dataRekordi.Columns.Add (columnBrSlova);

			List <Rekord> rekordi;
			rekordi = client.PreuzmiRekorde (null);
			var bindRekordi = new BindingList<Rekord> (rekordi);

			dataRekordi.DataSource = bindRekordi;
		}
    }
}
