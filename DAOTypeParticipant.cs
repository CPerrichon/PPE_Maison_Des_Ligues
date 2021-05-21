using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOTypeParticipant
    {
        public static List<TypeParticipant> getAllTypeParticipants()
        {
            List<TypeParticipant> lesTypesParticipants = new List<TypeParticipant>();
            string req = "Select * from TypeParticipant";
            DAOFactory daoTP = new DAOFactory();
            daoTP.connecter();
            
            SqlDataReader reader = daoTP.excecSQLRead(req);

            while (reader.Read())
            {
                TypeParticipant tp = new TypeParticipant(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesTypesParticipants.Add(tp);
            }

            return lesTypesParticipants;
        }
        
        
        
    }
}