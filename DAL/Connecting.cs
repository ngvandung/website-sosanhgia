using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connecting
    {
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U6P065N\\SQLEXPRESS;Initial Catalog=web_sosanhgia;Integrated Security=True");

        public void openConnect()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                Console.WriteLine("Connect Fail!");
            }
        }

        public void closeConnect()
        {
            conn.Close();
        }
    }
}
