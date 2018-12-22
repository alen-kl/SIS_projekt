using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_projekt
{
    public partial class FrmRegistracija : Form
    {
        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            if (provjeriGresku())
            {
                MessageBox.Show("Niste upisali sva polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (provjeraPotvrdeLozinke())
            {
                MessageBox.Show("Provjerite potvrdu lozinke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string korisnickoIme = txtKorisnicko.Text;
            string email = txtEMail.Text;
            string lozinka = txtLozinka.Text;
            RSA r = new RSA();
            string status=r.Registriraj(korisnickoIme, email, lozinka);

            if (status=="uspjesno")
            {
                MessageBox.Show("Uspješno ste se registrirali. Generirani su vam RSA ključevi.", ":)", MessageBoxButtons.OK);
                this.Close();
            }
            else if (status=="duplikat")
            {
                MessageBox.Show("Takav račun postoji u bazi!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Dogodila se greška...", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool provjeriGresku()
        {
            if (String.IsNullOrEmpty(txtKorisnicko.Text)||String.IsNullOrEmpty(txtEMail.Text)||String.IsNullOrEmpty(txtLozinka.Text)||String.IsNullOrEmpty(txtPotvrdaLozinke.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool provjeraPotvrdeLozinke()
        {
            if (txtLozinka.Text != txtPotvrdaLozinke.Text)
            {
                return true;
            }
            else return false;
        }
    }
}
