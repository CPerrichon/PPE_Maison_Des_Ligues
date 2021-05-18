﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE_Maison_Des_Ligues
{
    public class DAOParticipant
    {
        public static List<Participant> getAllParticipants()
        {
            List<Participant> lesParticipants = new List<Participant>();
            string req = "Select * from participant";
            DAOFactory daoP = new DAOFactory();
            daoP.connecter();
            
            SqlDataReader reader = daoP.excecSQLRead(req);

            while (reader.Read())
            {
                Participant p = new Participant(
                    Int32.Parse(reader[0].ToString()), 
                    reader[1].ToString(),
                    reader[2].ToString(),
                    Int32.Parse(reader[3].ToString()),
                    reader[4].ToString(),
                    reader[5].ToString(),
                    reader[6].ToString(),
                    Int32.Parse(reader[7].ToString()),
                    Int32.Parse(reader[8].ToString()));
                
                lesParticipants.Add(p);
            }

            return lesParticipants;
        }

        
    }
}