using System.Data.SqlClient;
using System.Xml.Linq;

namespace PPE_Maison_Des_Ligues
{
    public class Connect
    {
        public static bool seConnecter(string id, string pw)
        {
            DAOFactory daoConnect = new DAOFactory();
            daoConnect.connecter();
            string req = "SELECT * FROM login WHERE username='" + id + "' AND password = '" + pw + "';";
            SqlDataReader reader = daoConnect.excecSQLRead(req);

            int compteur = 0;
            if (reader.Read())
            {
                compteur++;
            }
            else
            {
                return false;
            }
            return true;
            
        }
        
        
        
        /* Si vide ...
        if(txt_UserName.Text=="" || txt_Password.Text=="")
        {
            MessageBox.Show("Please provide UserName and Password");
            return;
        }*/
        
    }
}