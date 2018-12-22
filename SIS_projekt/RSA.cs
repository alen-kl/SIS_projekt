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

        public void generirajKljuceve()
        {
            rsa = new RSACryptoServiceProvider();
            //File.WriteAllText("../../RSA/javni_kljuc.txt", rsa.ToXmlString(false));
            //File.WriteAllText("../../RSA/privatni_kljuc.txt", rsa.ToXmlString(true));
            privatniKljuc = rsa.ToXmlString(true);
            javniKljuc = rsa.ToXmlString(false);

        }
        public string Registriraj(string korisnickoIme, string email, string lozinka)
        {
            generirajKljuceve();
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
    }
}
