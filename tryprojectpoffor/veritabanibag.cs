using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tryprojectpoffor
{
    class veritabanibag
    {
        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database = kitapcimcom; Uid = root; Pwd = 12345678;");
            MySqlConnection.ClearPool(baglanti);
            try { baglanti.Open(); }
            catch { }
            return (baglanti);
        }
    }
}
