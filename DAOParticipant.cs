using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOParticipant
    {
        public static List<Participant> getAllParticipants()
        {
            List<Participant> lesParticipants = new List<Participant>();
            string req = "Select * from Participant";
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();
            
            SqlDataReader reader = daoP.excecSQLRead(req);

            while (reader.Read())
            {
                Participant p = new Participant(int.Parse(reader[0].ToString()), reader[1].ToString(),reader[2].ToString(),int.Parse(reader[4].ToString()),reader[5].ToString(),reader[6].ToString(),float.Parse(reader[7].ToString()),int.Parse(reader[8].ToString()),int.Parse(reader[9].ToString()));
                lesParticipants.Add(p);
            }

            return lesParticipants;
        }
    }
}