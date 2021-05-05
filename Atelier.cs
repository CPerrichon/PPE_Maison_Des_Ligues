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
        public Atelier(int numAtelier, string libelleAtelier, int capaciteMax, DateTime debut, DateTime fin, int idParticipant)
        {
            this.NumAtelier = numAtelier;
            this.LibelleAtelier = libelleAtelier;
            this.CapaciteMax = capaciteMax;
            this.Debut = debut;
            this.Fin = fin;
            this.IdParticipant = idParticipant;
        }

        #region Accesseurs

        public int NumAtelier { get => numAtelier; set => numAtelier = value; }
        public string LibelleAtelier { get => libelleAtelier; set => libelleAtelier = value; }
        public int CapaciteMax { get => capaciteMax; set => capaciteMax = value; }
        public DateTime Debut { get => debut; set => debut = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public int IdParticipant { get => idParticipant; set => idParticipant = value; }
        #endregion
    }
}
