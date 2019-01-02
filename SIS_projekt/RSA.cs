using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;



namespace SIS_projekt
{
     public class RSA
    {
        private RSACryptoServiceProvider rsa;
        public string privatniKljuc { get; set; }
        public string javniKljuc { get; set; }

        public void generirajKljuceve(string email)
        {
            rsa = new RSACryptoServiceProvider();
            File.WriteAllText("../../RSA/javni_kljuc_"+email+".txt", rsa.ToXmlString(false));
            File.WriteAllText("../../RSA/privatni_kljuc_"+email+".txt", rsa.ToXmlString(true));
            privatniKljuc = rsa.ToXmlString(true);
            javniKljuc = rsa.ToXmlString(false);

        }
        public string Registriraj(string korisnickoIme, string email, string lozinka)
        {
            generirajKljuceve(email);
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["korIme"] = korisnickoIme;
                values["mail"] = email;
                values["lozinka"] = lozinka;
                values["javniKljuc"] = javniKljuc;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/registriranje.php", values);

                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }

        }

        public void spremiNoviKljuc(string email)
        {
            generirajKljuceve(email);
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["email"] = email;
                values["noviKljuc"] = javniKljuc;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/rsaNoviKljuc.php", values);

                var responseString = Encoding.Default.GetString(response);
               
            }
        }

        //metode za RSAkriptiranje i dekriptiranje
        public static string Enkripcija(string tekst, string kljuc)
        {
            // pretvorba  
            
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(tekst);

            byte[] encryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // javni ključ 
                rsa.FromXmlString(kljuc);

                // enkripcija   
                encryptedData = rsa.Encrypt(dataToEncrypt, false);
            }

            UnicodeEncoding byteConverter1 = new UnicodeEncoding();
            return Convert.ToBase64String(encryptedData);

        }

        public static string Dekripcija(string tekst, string kljuc)
        {
            byte[] dataToDecrypt = null;
            // čitanje  
            
            dataToDecrypt = Convert.FromBase64String(tekst);

            byte[] decryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // dekripcija 
                rsa.FromXmlString(kljuc);
                decryptedData = rsa.Decrypt(dataToDecrypt, false);
            }
            // vraćanje stringa   
            
            return Encoding.UTF8.GetString(decryptedData);
        }

    }
}
