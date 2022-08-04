using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace institute
{
    public class DataBase
    {
        public void connect()
        {
            string connectionString = $"server=127.0.0.1;Port=3306;uid = root; pwd = root; database = mydata";

            MySqlConnection connObj = new MySqlConnection(connectionString);

            connObj.Open();

            string query = "select * from students";
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, connObj);


            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object[] a = new object[5];
                reader.GetValues(a);
                for (int i = 0; i < a.Length; i++)
                {
                    Trace.WriteLine(a[i].ToString());
                }
            }


        }
    }
}
