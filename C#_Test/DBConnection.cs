using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Test
{
    public class DBConnection
    {
        private string sqlString = "Data Source = .; Initial Catalog = PRODUCT; Integrated Security = true;";
        public SqlConnection con;
        public void Connection()
        {
            con = new SqlConnection(sqlString);
            con.Open();
            if(SqlDependency.Start(sqlString) == false)
            {
                SqlDependency.Start(sqlString);
            }
        }
    }
}
