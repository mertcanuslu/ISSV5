using ISS.DAL;
using ISS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.BLL
{
    public class MusteriBL
    {
        public List<Musteri> MusteriListele(int m_id)
        {
            Helper hlp = new Helper();
            List<Musteri> mstrlst = new List<Musteri>();
            Musteri mstr = null;
            SqlParameter[] p = { new SqlParameter("@mID", m_id)};
            SqlDataReader dr = hlp.ExecuteReader("SELECT * from ttnetTablo WHERE musteriId=@mID", p);
            if (dr.Read())
            {
                mstr = new Musteri();
                mstr.musteri_ad = dr[1].ToString();
                mstr.musteri_adres = dr[5].ToString();
                mstr.musteri_mail = dr[2].ToString();
                mstr.musteri_paket = dr[6].ToString();
                mstr.musteri_sifre = dr[3].ToString();
                mstr.musteri_tel = dr[4].ToString();
                mstrlst.Add(mstr);
            }
            hlp.Dispose();
            return mstrlst;

        }
    }
}
