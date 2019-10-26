using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class GENNERAL
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=.\;Initial Catalog=QLSP;Integrated Security=True");
        public SqlConnection getConnect()
        {
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
