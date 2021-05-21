using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOHorrairesBenevoles
    {
        public static List<HorrairesBenevoles> getAllHorrairesBenevoles()
        {
            List<HorrairesBenevoles> lesHorrairesBenevoles = new List<HorrairesBenevoles>();
            string req = "Select * from HorrairesBenevoles";
            DAOFactory daoHB = new DAOFactory();
            daoHB.connecter();
            
            SqlDataReader reader = daoHB.excecSQLRead(req);

            while (reader.Read())
            {
                HorrairesBenevoles hb = new HorrairesBenevoles(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesHorrairesBenevoles.Add(hb);
            }

            return lesHorrairesBenevoles;
        }
    }
}