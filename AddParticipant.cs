using System.Data.SqlClient;
using System.Xml.Linq;

namespace PPE_Maison_Des_Ligues
{
    public class AddParticipant
    {
        public void AjouterParticipant(int unId, string unNom, string unPrenom, int unIdType, string unMail,
                    string unNumPortable, int unIdAtelier, int unIdHorraireBenevoles)
                {
                    DAOFactory daoAddP = new DAOFactory();
                    daoAddP.connecter();
                    string req = "INSERT INTO participant (id, nom, prenom, idtype, adresse, mail, numPortable, idAtelier, idHorraireBenevoles) VALUES ('" + unId + "','" + unNom + "','" + unPrenom + "','" + unIdType + "','" + unMail + "','" + unNumPortable + "','" + unIdAtelier + "','" + unIdHorraireBenevoles + "')";
                    daoAddP.execSQLWrite(req);
                }
    }
}