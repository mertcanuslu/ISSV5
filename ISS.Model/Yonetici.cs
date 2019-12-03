using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.Model
{
   public class Yonetici
    {
        String Saglayici_sirket, Saglayici_mail, Saglayici_sifre;



        public string saglayici_sirket { get => Saglayici_sirket; set => Saglayici_sirket = value; }
        public string saglayici_mail { get => Saglayici_mail; set => Saglayici_mail = value; }
        public string saglayici_sifre { get => Saglayici_sifre; set => Saglayici_sifre = value; }

    }
}
