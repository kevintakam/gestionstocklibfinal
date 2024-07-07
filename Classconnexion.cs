using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace gestiondestocklib
{
    class Classconnexion
    {
        public static MySqlConnection maconnexion;
        public Classconnexion()
        {
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = "localhost";
            conn.UserID = "root";
            conn.Password = "";
            conn.Port=3306;
            conn.Database = "bd_stock";
            var connString = conn.ToString();
            maconnexion = new MySqlConnection(connString);
            try
            {
                maconnexion.Open();
            }
            catch(Exception ex)
            {
                maconnexion = null;
                Console.WriteLine(ex.StackTrace);
            }

        }
        public static MySqlConnection getconnection()
        {
            if (maconnexion == null)
            {
                new Classconnexion();
            }
            return maconnexion;
        }
        public static void closeconnection()
        {
            if(maconnexion != null)
            {
           
                maconnexion.Close();
                maconnexion = null;
            }
        }
 
    }
}
