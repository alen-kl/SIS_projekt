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

namespace SIS_projekt
{
    public partial class Simetricno : Form
    {
        AES aes = new AES();
     
        string datoteka = "";
        string fileName = "";

        string inicijalniDirektorij = @"..\..\..\" + Environment.CurrentDirectory;
        string putanjaTajniKljuc = @"..\..\..\simetricni_kljuc.txt";
        string izlaznaPutanjaKriptirani = @"..\..\..\";

        public Simetricno()
        {
            InitializeComponent();
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
                ucitaniTeksttxt.Text = datoteka;
                label1.Text = "Učitani tekst";
            }
        }

        private void btnGenerirajKljuc_Click(object sender, EventArgs e)
        {
            aes.generirajKljuc();

            using (StreamWriter streamWriter = new StreamWriter(putanjaTajniKljuc))
            {
                streamWriter.WriteLine(Convert.ToBase64String(aes.TajniKljuc));
                streamWriter.WriteLine(Convert.ToBase64String(aes.InicijalizacijskiVektor));
            }

            generiraniKljuctxt.Text = Convert.ToBase64String(aes.TajniKljuc);
            MessageBox.Show("Generiran ključ i inicijalizacijski vektor");
        }

        private void UcitajKljuc()
        {
            using (StreamReader streamReader = new StreamReader(putanjaTajniKljuc))
            {
                string kljuc = streamReader.ReadLine();
                if (string.IsNullOrWhiteSpace(kljuc))
                {
                    MessageBox.Show("Ključ nije generiran!");

                }
                else
                {
                    aes.TajniKljuc = Convert.FromBase64String(kljuc);
                }

                string vektor = streamReader.ReadLine();
                if (string.IsNullOrWhiteSpace(vektor))
                {
                    MessageBox.Show("Inicijalizacijski vektor nije generiran!");
                }
                else
                {
                    aes.InicijalizacijskiVektor = Convert.FromBase64String(vektor);
                }
            }
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(datoteka))
            {
                try
                {
                    UcitajKljuc();

                    string sifrat = aes.enkripcija(aes.TajniKljuc, aes.InicijalizacijskiVektor, datoteka);

                    string izlaznaPutanjaKriptirani2 = izlaznaPutanjaKriptirani + "Enc_" + fileName;
                    File.WriteAllText(izlaznaPutanjaKriptirani2, sifrat);
                    label1.Text = "Kriptirani tekst";
                    ucitaniTeksttxt.Text = sifrat;
                    MessageBox.Show("Datoteka kriptirana!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate učitati datoteku!");
            }
        }
    }
}
