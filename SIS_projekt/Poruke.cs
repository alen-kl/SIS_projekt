using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace SIS_projekt
{
    public class Poruke
    {
        public string posiljatelj { get; set; }
        public string nazivDatoteke { get; set; }
        public string IV { get; set; }
        public string decSimetricniKljuc { get; set; }
        public string hash { get; set; }
        public string procitano { get; set; }

        public static List<Poruke> downloadPoruka(string mailKorisnika)
        {
            List<Poruke> listaPoruka = new List<Poruke>();
            
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["mail"] = mailKorisnika;

                var response = client.UploadValues("https://siskriptiranje.000webhostapp.com/listaPoruka.php", values);
                var responseString = Encoding.Default.GetString(response);

                if (responseString == "prazno")
                {
                    listaPoruka = null;
                }
                else
                {
                    responseString = responseString.Remove(responseString.Length - 1);

                    string[] poruke = responseString.Split('#');
                    foreach (string item in poruke)
                    {
                        string[] items = item.Split(';');
                        Poruke p = new Poruke();
                        p.posiljatelj = items[0];
                        p.nazivDatoteke = items[1];
                        p.decSimetricniKljuc = items[2];
                        p.IV = items[3];
                        p.hash = items[4];
                        if (items[5] == "1") p.procitano = "da";
                        else p.procitano = "ne";
                        listaPoruka.Add(p);
                    }
                }
                return listaPoruka;
            }
        }
    }
}
