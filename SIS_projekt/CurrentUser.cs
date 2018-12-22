using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_projekt
{
    class CurrentUser
    {
        public static CurrentUser User { set; get; }

        public string Mail { set; get; }

        public CurrentUser(string mail)
        {
            Mail = mail;
        }
    }
}
