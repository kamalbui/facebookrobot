using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace facebook
{
    class Dbhandler
    {
        private string connectionstring = "";
        public DataSet GetAllUsers()
        {
            Database fbdb = DatabaseFactory.CreateDatabase(connectionstring);
           
            SqlCommand cmd = new SqlCommand("Select * from signup");

            return fbdb.ExecuteDataSet(cmd);
           

        }


        public Dbhandler()
        {
            connectionstring = "Fbcon";
        }
        bool Login(string username, string password)
        {
            
            
            return true;
        }
    }
}
