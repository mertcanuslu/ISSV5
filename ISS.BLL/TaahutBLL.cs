using ISS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.Model;
using System.Data.SqlClient;

namespace ISS.BLL
{
   public class TaahutBLL
    {
        public List<Taahut> TaahutListele()
        {
            Helper hlpme = new Helper();
            List<Taahut> pkt = new List<Taahut>();

            SqlDataReader dr = hlpme.ExecuteReader("Select taahut_id, musteri_id, taahut_bitis FROM taahutler", null);
            while (dr.Read())
            {
                pkt.Add(new Taahut { musteriid = Convert.ToInt32(dr["musteri_id"]),taahutbitis = dr["taahut_bitis"].ToString(),taahutid= Convert.ToInt32(dr["taahut_id"]) });
            }
            dr.Close();
            hlpme.Dispose();

            return pkt;
        }
    }
}
