﻿using System;
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
        AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
        byte[] tajniKljuc = null;
        byte[] inicijalizacijskiVektor = null;
        string datoteka = "";
        string fileName = "";

        string inicijalniDirektorij = @"C:\Users\Darko\FAKS\DS_1_semestar\SIS\PROJEKT\SIS_projekt";//promijeniti na kraju na C:\ ili na svoju putanju
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
            AES.KeySize = 256;
            AES.Mode = CipherMode.CBC;
            AES.GenerateKey();
            AES.GenerateIV();

            using (StreamWriter streamWriter = new StreamWriter(putanjaTajniKljuc))
            {
                streamWriter.WriteLine(Convert.ToBase64String(AES.Key));
                streamWriter.WriteLine(Convert.ToBase64String(AES.IV));
            }

            generiraniKljuctxt.Text = Convert.ToBase64String(AES.Key);
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
                    tajniKljuc = Convert.FromBase64String(kljuc);
                }

                string vektor = streamReader.ReadLine();
                if (string.IsNullOrWhiteSpace(vektor))
                {
                    MessageBox.Show("Inicijalizacijski vektor nije generiran!");
                }
                else
                {
                    inicijalizacijskiVektor = Convert.FromBase64String(vektor);
                }
            }
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(datoteka))
            {
                try
                {
                    byte[] plainText = Encoding.UTF8.GetBytes(datoteka);
                    UcitajKljuc();
                    AES.Key = tajniKljuc;
                    AES.IV = inicijalizacijskiVektor;
                    ICryptoTransform cryptoTransform = AES.CreateEncryptor(AES.Key, AES.IV);
                    byte[] kriptiranaDatoteka = cryptoTransform.TransformFinalBlock(plainText, 0, plainText.Length);
                    string sifrat = Convert.ToBase64String(kriptiranaDatoteka);
                    izlaznaPutanjaKriptirani += "Enc_" + fileName;
                    File.WriteAllText(izlaznaPutanjaKriptirani, sifrat);
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
