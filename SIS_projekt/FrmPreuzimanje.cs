using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace SIS_projekt
{
    public partial class FrmPreuzimanje : Form
    {
        string putanjaPrivatniKljuc = @"..\..\RSA\privatni_kljuc_" + CurrentUser.User.Mail + ".txt";
        string izlaznaPutanjaDekriptirani = @"..\..\..\";
        public FrmPreuzimanje()
        {
            InitializeComponent();
        }

        private void FrmPreuzimanje_Load(object sender, EventArgs e)
        {
            refreshPoruke();
            changeColor();
        }
        private void changeColor()
        {
            foreach (DataGridViewRow row in dgvPoruke.Rows)
            {
                Poruke poruka = row.DataBoundItem as Poruke;
                if (poruka.procitano == "ne")
                {
                    row.DefaultCellStyle.ForeColor = Color.Gold;
                }
            }
        }
        private void refreshPoruke()
        {
            List<Poruke> poruke = Poruke.downloadPoruka(CurrentUser.User.Mail);
            if (poruke != null)
            {
                dgvPoruke.DataSource = poruke;
                dgvPoruke.Columns[0].HeaderText = "POŠILJATELJ";
                dgvPoruke.Columns[1].HeaderText = "NAZIV DATOTEKE";
                dgvPoruke.Columns[5].HeaderText = "PROČITANO?";
                dgvPoruke.Columns[2].Visible = false;
                dgvPoruke.Columns[3].Visible = false;
                dgvPoruke.Columns[4].Visible = false;
                dgvPoruke.Columns[0].Width = 250;
                dgvPoruke.Columns[1].Width = 300;
                dgvPoruke.Columns[5].Width = 90;
                dgvPoruke.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                changeColor();

            }
        }

        private void btnOsvjeziPoruke_Click(object sender, EventArgs e)
        {
            refreshPoruke();
        }

        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            if (dgvPoruke.SelectedRows.Count > 0)
            {
                Poruke poruka = dgvPoruke.SelectedRows[0].DataBoundItem as Poruke;
                string preuzetaPoruka=preuzimanjePoruke(poruka.nazivDatoteke);
                refreshPoruke();
                string preuzetiKljuc = PreuzmiKljuc(poruka.nazivDatoteke);
                string preuzetiIV = PreuzmiIV(poruka.nazivDatoteke);
                string privatniKljuc = File.ReadAllText(putanjaPrivatniKljuc);

                string dekriptiraniSimetricni = RSA.Dekripcija(preuzetiKljuc, privatniKljuc);
                string dekriptiraniIV = RSA.Dekripcija(preuzetiIV, privatniKljuc);
                string dekriptiranaDatoteka = AES.Dekripcija(dekriptiraniSimetricni, dekriptiraniIV, preuzetaPoruka);
                txtDekriptirano.Text = dekriptiranaDatoteka;

                string putanja = izlaznaPutanjaDekriptirani + "Dec_" + poruka.nazivDatoteke;
                File.WriteAllText(putanja, dekriptiranaDatoteka);
                MessageBox.Show("Datoteka je preuzeta i dekriptirana! Naziv dekriptirane datoteke: " + "Dec_" + poruka.nazivDatoteke);
            }
        }

        private string preuzimanjePoruke(string naziv)
        {
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["datotekaIme"] = naziv;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/downloadDatoteke.php", values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }

        private string PreuzmiKljuc(string naziv)
        {
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["datotekaIme"] = naziv;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/downloadKljuca.php", values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }

        private string PreuzmiIV(string naziv)
        {
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["datotekaIme"] = naziv;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/downloadIV.php", values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
    }
}
