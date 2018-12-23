using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace SIS_projekt
{
    public partial class FrmPrijava : Form
    {
        public FrmIzbornik parent = null;

        public FrmPrijava(FrmIzbornik izbornik)
        {
            InitializeComponent();
            this.parent = izbornik;
        }

        private void radioMail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMail.Checked == true)
            {
                txtMail.Enabled = true;
                txtKorIme.Enabled = false;

            }
        }

        private void radioKorIme_CheckedChanged(object sender, EventArgs e)
        {
            txtMail.Enabled = false;
            txtKorIme.Enabled = true;
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            txtKorIme.Enabled = false;
        }

        private void tnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija();
            frmRegistracija.ShowDialog();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            string podatakZaPrijavu = null;
            if (radioKorIme.Checked)
            {
                podatakZaPrijavu = txtKorIme.Text;
            }
            else
            {
                podatakZaPrijavu = txtMail.Text;
            }
            string lozinka = txtLozinka.Text;

            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["logPodatak"] = podatakZaPrijavu;
                values["lozinka"] = lozinka;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/prijava.php", values);

                var responseString = Encoding.Default.GetString(response);

                if (responseString == "neuspjesno")
                {
                    MessageBox.Show("Neuspješna prijava!", ":((", MessageBoxButtons.OK);
                }
                else
                {
                    //uspješna prijava
                    File.WriteAllText("../../zadnjiPrijavljeni.txt", responseString);
                    parent.korisnik.Mail = responseString;
                    parent.gumbiPrijavljeni();
                    this.Close();
                }

            }

        }
    }
}
