using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SIS_projekt
{
    public partial class FrmSend : Form
    {
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);

        string inicijalniDirektorij = @"C:\Users\Darko\FAKS\DS_1_semestar\SIS\PROJEKT\SIS_projekt";//promijeniti na kraju na C:\ ili na svoju putanju
        string putanjaTajniKljuc = @"..\..\..\simetricni_kljuc.txt";
        string putanjaPrimatelji = @"..\..\..\primatelji.txt";
        string putanjaJavniKljuc = @"..\..\..\javni_kljuc.txt";//samo za testiranje

        string datoteka = "";
        string fileName = "";

        string javniKljuc = "";
        string simetricniKljuc = "";
        string inicijalizacijskiVektor = "";
        string kriptiraniSimetricniKljuc = "";
        string kriptiraniInicijalizacijskiVektor = "";

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

        //TODO  metoda za dohvat iz baze javnog ključa primatelja prema mail-u primatelja


        private void UcitajKljuceve()
        {
            javniKljuc = XElement.Load(putanjaJavniKljuc).ToString();//za testiranje

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

            //TODO provjeri da li su unešeni podaci i pošalji na server
        }

        private void KriptirajSimetricni()
        {
            try
            {
                RSA.FromXmlString(javniKljuc);
                byte[] kljuc = RSA.Encrypt(Encoding.UTF8.GetBytes(simetricniKljuc), false);
                byte[] iv = RSA.Encrypt(Encoding.UTF8.GetBytes(inicijalizacijskiVektor), false);
                kriptiraniSimetricniKljuc = Convert.ToBase64String(kljuc);
                kriptiraniInicijalizacijskiVektor = Convert.ToBase64String(iv);

                //TEST
                //File.WriteAllText(@"..\..\..\kriptiraniSimetricni.txt", kriptiraniSimetricniKljuc);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //TODO metoda za slanje podataka na server
    }
}
