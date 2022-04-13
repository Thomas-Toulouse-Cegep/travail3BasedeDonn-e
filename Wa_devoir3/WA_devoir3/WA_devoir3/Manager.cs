using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WA_devoir3
{
    class Manager
    {
        protected SqlConnection getConection()
        {
            SqlConnection Cnn = new SqlConnection();
            Cnn.ConnectionString = "Data Source=LAPTOP-KSTAFJOR;Initial Catalog=XDTTmecanicien ;Integrated Security=True";
            return Cnn;
        }
    }
}
