 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Library_management
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            //string str = @"Data Source=( LocalDB MSSQLLocalDB;Intial Catalog=BookDB;Integrated Security=True";
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BookDB;Integrated Security=true";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        //unpdate excute
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //read sql
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader(); 
        }
        //close sql connection
        public void DaoClose()
        {
            sc.Close();
        }
            
    }
}
