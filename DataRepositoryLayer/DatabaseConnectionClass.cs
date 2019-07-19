using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataRepositoryLayer
{
    public class DatabaseConnectionClass
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public object NEXT { get; private set; }
        public object MainDataBaseForProject { get; private set; }

        public DatabaseConnectionClass()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEXT\Desktop\ProjectNext\SilverLightTest.mdf;Integrated Security=True;Connect Timeout=30";
            myConnection =new SqlConnection(connectionString);
        }
        public void ConnectWithDB()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }
        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteReader();
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //int x = myCommand.ExecuteNonQuery();
            //return x;
            return myCommand.ExecuteNonQuery();
        }
    }
}
