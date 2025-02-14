using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OH4EKOT\\MSSQLSERVER01;Initial Catalog=HastaneYonetim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
