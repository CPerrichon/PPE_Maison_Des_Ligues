using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    class DAOFactory
    {
        SqlConnection connexion;

        public DAOFactory()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LAPTOP-FJB9U9UG";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "Banque";
            Console.WriteLine("Connexion info created : " + builder.ConnectionString);
            connexion = new SqlConnection(builder.ConnectionString);
        }

        public void connecter()
        {
            connexion.Open();
        }

        public void deconnecter()
        {
            connexion.Close();

        }
    }
}
