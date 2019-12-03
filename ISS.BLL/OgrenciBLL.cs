using ISS.DAL;
using ISS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.BLL
{
    public class OgrenciBLL
    {

        public bool  Musteri_Ekle(Musteri mstr)
        {
            Helper hlp = new Helper();
            
            SqlParameter[] p = { new SqlParameter("@Ad", mstr.musteri_ad), new SqlParameter("@Mail", mstr.musteri_mail), new SqlParameter("@Sifre", mstr.musteri_sifre), new SqlParameter("@Tel", mstr.musteri_tel), new SqlParameter("@Adres", mstr.musteri_adres), new SqlParameter("@Paket", mstr.musteri_paket) };

           

            return hlp.ExecuteNonQuery("INSERT into musteriler values (@Ad,@Mail,@Sifre,@Tel,@Adres,@Paket)",p) > 0 ;
        }
    }
}
