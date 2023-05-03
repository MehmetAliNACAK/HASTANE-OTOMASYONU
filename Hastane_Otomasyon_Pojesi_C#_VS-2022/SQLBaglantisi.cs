using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Pojesi
{
    internal class SQLBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-6D7O113Q\\SQLEXPRESS;Initial Catalog=Hastane_Otomasyon_Projesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
