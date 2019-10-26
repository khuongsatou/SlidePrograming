using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class General
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLSV;Integrated Security=true");
        public DataTable dt = new DataTable();
        public SqlConnection getConnect()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect;
        }
    }
}
