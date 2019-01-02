using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIS_projekt
{
    public class AES
    {
        private AesCryptoServiceProvider aes;
        public byte[] TajniKljuc { get; set; }
        public byte[] InicijalizacijskiVektor { get; set; }

        public void generirajKljuc()
        {
            aes = new AesCryptoServiceProvider();
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;
            aes.GenerateKey();
            aes.GenerateIV();
            TajniKljuc = aes.Key;
            InicijalizacijskiVektor = aes.IV;
        }

        public string enkripcija(byte[] key, byte[] iv, string datoteka)
        {
            byte[] plainText = Encoding.UTF8.GetBytes(datoteka);
            string sifrat;
            using (aes = new AesCryptoServiceProvider())
            {
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] kriptiranaDatoteka = cryptoTransform.TransformFinalBlock(plainText, 0, plainText.Length);
                sifrat = Convert.ToBase64String(kriptiranaDatoteka);
            }

            return sifrat;
        }

        public static string Dekripcija(string key, string iv, string datoteka)
        {
            byte[] kriptiranaDatoteka = Convert.FromBase64String(datoteka);
            byte[] kljuc = Convert.FromBase64String(key);
            byte[] inicijalizacijskiVektor = Convert.FromBase64String(iv);
            string dekriptirano;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = kljuc;
                aes.IV = inicijalizacijskiVektor;
                ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] dekriptiranaDatoteka = cryptoTransform.TransformFinalBlock(kriptiranaDatoteka, 0, kriptiranaDatoteka.Length);
                dekriptirano = Encoding.UTF8.GetString(dekriptiranaDatoteka);
            }
            return dekriptirano;
        }
    }

}
