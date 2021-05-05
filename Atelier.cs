using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Maison_Des_Ligues
{
    class Atelier
    {
        #region Propriétés privées
        private int numAtelier;
        private string libelleAtelier;
        private int capaciteMax;
        private DateTime debut;
        private DateTime fin;
        private int idParticipant;
        #endregion

        #region Constructeur

        public Atelier(int unNumAtelier, string unlibelleAtelier, private int unecapaciteMax, DateTime undebut, DateTime unefin, int unidParticipant)
            {
                numAtelier = unNumAtelier;
                libelleAtelier = unLibelleAtelier;
                
            }

    }
}
