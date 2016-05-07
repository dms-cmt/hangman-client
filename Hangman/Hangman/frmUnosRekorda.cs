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
    public partial class frmUnosRekorda : Form
    {
		private HangmanClient client;

		public frmUnosRekorda(HangmanClient client = null)
        {
			this.client = client;
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (client == null)
			{
				MessageBox.Show ("Problem u komunikaciji sa servisom!");
				return;
			}
			if (textBox1.Text.Length == 0)
			{
				MessageBox.Show ("Niste uneli ime!");
				return;
			}
			client.SnimiRekord (textBox1.Text);
			MessageBox.Show ("Podaci uspesno snimljeni.");
			Close ();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Close ();
        }
    }
}
