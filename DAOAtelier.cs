using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    class DAOAtelier
    {
        public static List<Atelier> getAllAteliers()
        {
            List<Atelier> lesAteliers = new List<Atelier>();
            string req = "Select * from atelier";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Atelier at = new Atelier(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), DateTime.Parse(reader[3].ToString()), DateTime.Parse(reader[4].ToString()), int.Parse(reader[5].ToString()));
                lesAteliers.Add(at);
            }

            return lesAteliers;
        }
    }
}
