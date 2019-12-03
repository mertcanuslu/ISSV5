using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.DAL;
using ISS.Model;
namespace ISS.BLL
{
   public class PaketBLL 
    {
        public List<Paket> PaketListele() 
        {
            Helper hlpme = new Helper();
            List<Paket> pkt = new List<Paket>();

           SqlDataReader dr = hlpme.ExecuteReader("Select paket_id, paket_adi, paket_fiyati, paket_saglayici, paket_taahut, paket_hiz FROM paketler", null);
            while (dr.Read())
            {
                pkt.Add(new Paket { paketid = Convert.ToInt32(dr["paket_id"]), paketadi = dr["paket_adi"].ToString(), paketfiyati = int.Parse(dr["paket_fiyati"].ToString()), pakethiz = Convert.ToInt32(dr["paket_hiz"]), paketsaglayici = Convert.ToInt32(dr["paket_saglayici"]), pakettaahut = Convert.ToInt32(dr["paket_taahut"]) });
            }
            dr.Close();
            hlpme.Dispose();
            return pkt;
        }
    }
}
