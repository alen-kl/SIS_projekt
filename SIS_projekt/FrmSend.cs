using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SIS_projekt
{
    public partial class FrmSend : Form
    {

        string inicijalniDirektorij = @"C:\Users\Darko\FAKS\DS_1_semestar\SIS\PROJEKT\SIS_projekt";//promijeniti na kraju na C:\ ili na svoju putanju
        string putanjaTajniKljuc = @"..\..\..\simetricni_kljuc.txt";
        string putanjaPrimatelji = @"..\..\..\primatelji.txt";
        string putanjaPrivatniKljuc = @"..\..\RSA\privatni_kljuc_" + CurrentUser.User.Mail + ".txt";


        string datoteka = "";
        string datotekaZaHash = "";
        string fileName = "";

        string javniKljuc = "";
        string simetricniKljuc = "";
        string inicijalizacijskiVektor = "";
        string kriptiraniSimetricniKljuc = "";
        string kriptiraniInicijalizacijskiVektor = "";
        string digitalniPotpis = "";

        public FrmSend()
        {
            InitializeComponent();

            FillComboPrimatelji();
        }

        private void btnOdabirDatoteke_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT files|*.txt";
            fileDialog.InitialDirectory = inicijalniDirektorij;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                nazivDatoteketxt.Text = fileDialog.FileName;
                fileName = Path.GetFileName(nazivDatoteketxt.Text);
                datoteka = File.ReadAllText(nazivDatoteketxt.Text, Encoding.UTF8);
            
                
            }
        }

        private void FillComboPrimatelji()
        {
            List<string> primatelji = new List<string>();
            string line;
            StreamReader reader = new StreamReader(putanjaPrimatelji);
            while((line = reader.ReadLine()) != null)
            {
                primatelji.Add(line);
            }
            reader.Close();

            foreach (var item in primatelji)
            {
                cmbPrimatelji.Items.Add(item);
            }
        }

        private void btnDodajNoviMail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNoviMail.Text))
            {
                File.AppendAllText(putanjaPrimatelji, txtNoviMail.Text + Environment.NewLine);
                MessageBox.Show("Mail dodan!");
                cmbPrimatelji.Items.Clear();
                FillComboPrimatelji();
            }
        }

        //  metoda za dohvat iz baze javnog ključa primatelja prema mail-u primatelja
        private void DohvatiJavniKljucPrimatelja()
        {
  
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                if(cmbPrimatelji.SelectedIndex > -1)
                {
                    values["mail"] = cmbPrimatelji.SelectedItem.ToString();
                    var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/getJavniRSA.php", values);
                    javniKljuc = Encoding.Default.GetString(response);
                    if (string.IsNullOrWhiteSpace(javniKljuc))
                    {
                        MessageBox.Show("Greška prilikom dohvata javnog ključa!");
                    }

                }
                else
                {
                    MessageBox.Show("Morate odabrati primatelja!");
                }
                
            }
            
            
        }


        private void UcitajKljuceve()
        {
            DohvatiJavniKljucPrimatelja();

            using (StreamReader streamReader = new StreamReader(putanjaTajniKljuc))
            {
                simetricniKljuc = streamReader.ReadLine();
                if (string.IsNullOrWhiteSpace(simetricniKljuc))
                {
                    MessageBox.Show("Ključ nije generiran!");

                }
              

                inicijalizacijskiVektor = streamReader.ReadLine();
                if (string.IsNullOrWhiteSpace(inicijalizacijskiVektor))
                {
                    MessageBox.Show("Inicijalizacijski vektor nije generiran!");
                }
              
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UcitajKljuceve();
            KriptirajSimetricni();
            PotpisiDatZaHash();

            // provjeri da li su unešeni podaci i pošalji na server
            if (ProvjeriPodatke())
            {
                Posalji();
            }
        }

        private void KriptirajSimetricni()
        {
            try
            {
                if(string.IsNullOrWhiteSpace(simetricniKljuc) || string.IsNullOrWhiteSpace(javniKljuc))
                {
                    MessageBox.Show("Nije učitan simetrični ili javni ključ!");
                }
                else
                {
                    kriptiraniSimetricniKljuc = RSA.Enkripcija(simetricniKljuc, javniKljuc);
                    kriptiraniInicijalizacijskiVektor = RSA.Enkripcija(inicijalizacijskiVektor, javniKljuc);

                    //MessageBox.Show(kriptiraniSimetricniKljuc);
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ProvjeriPodatke()
        {
            bool odabrano = true;
            if (string.IsNullOrWhiteSpace(datotekaZaHash))
            {
                odabrano = false;
                MessageBox.Show("Odaberite originalnu datoteku za digitalni potpis!");
            }
            if (string.IsNullOrWhiteSpace(datoteka))
            {
                odabrano = false;
                MessageBox.Show("Niste odabrali kriptiranu datoteku!");
            }
            if(cmbPrimatelji.SelectedIndex == -1)
            {
                odabrano = false;
                MessageBox.Show("Odaberite primatelja");
            }
            if(string.IsNullOrWhiteSpace(kriptiraniSimetricniKljuc) || string.IsNullOrWhiteSpace(kriptiraniInicijalizacijskiVektor))
            {
                odabrano = false;
                MessageBox.Show("Nije kriptiran simetrični ključ");
            }
            if (string.IsNullOrWhiteSpace(digitalniPotpis))
            {
                odabrano = false;
                MessageBox.Show("Nije napravljen digitalni potpis!");
            }

            return odabrano;
        }

        //TODO metoda za slanje podataka na server
        private void Posalji()
        {
            if (string.IsNullOrEmpty(CurrentUser.User.Mail))
            {
                MessageBox.Show("Morate se prijaviti");
            }
            else
            {
                using (var client = new WebClient())
                {
                    var values = new NameValueCollection();
                    values["posiljatelj"] = CurrentUser.User.Mail;
                    values["primatelj"] = cmbPrimatelji.SelectedItem.ToString();
                    values["datoteka"] = datoteka;
                    values["datotekaIme"] = fileName;
                    values["kljuc"] = kriptiraniSimetricniKljuc;
                    values["iv"] = kriptiraniInicijalizacijskiVektor;
                    values["hash"] = digitalniPotpis;

                    var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/uploadDatoteke.php", values);
                    string zapisano = Encoding.Default.GetString(response);
                    if (zapisano.Equals("zapisano"))
                    {
                        MessageBox.Show("Podaci poslani!");
                    }
                    else
                    {
                        MessageBox.Show("Greška kod prijenosa podataka!");
                    }
                }
            }
            
        }

        private void btnOdabirDatotekeZaHash_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT files|*.txt";
            fileDialog.InitialDirectory = inicijalniDirektorij;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDatotekaZaHash.Text = fileDialog.FileName;
                
                datotekaZaHash = File.ReadAllText(txtDatotekaZaHash.Text, Encoding.UTF8);


            }
        }

        private void PotpisiDatZaHash()
        {
            if (string.IsNullOrWhiteSpace(datotekaZaHash))
            {
                MessageBox.Show("Odaberite originalnu datoteku za digitalni potpis!");
            }
            else
            {
                string privatniKljuc = File.ReadAllText(putanjaPrivatniKljuc);
                if (string.IsNullOrWhiteSpace(privatniKljuc))
                {
                    MessageBox.Show("Morate generirati privatni RSA ključ!");
                }
                else
                {
                    digitalniPotpis = RSA.DigitalniPotpis(datotekaZaHash, privatniKljuc);
                }
            }
        }
    }
}
