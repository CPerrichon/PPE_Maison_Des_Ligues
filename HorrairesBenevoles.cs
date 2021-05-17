using System.Collections.Generic;

namespace PPE_Maison_Des_Ligues
{
    public class HorrairesBenevoles
    {
        #region Propriétés privées

        private int idHorraires;
        private string libelleHorraires;

        #endregion

        #region Constructeur

        public HorrairesBenevoles(int idHorraires, string libelleHorraires)
        {
            this.idHorraires = idHorraires;
            this.libelleHorraires = libelleHorraires;
        }

        #endregion

        #region Accesseurs

        public int IdHorraires
        {
            get => idHorraires;
            set => idHorraires = value;
        }

        public string LibelleHorraires
        {
            get => libelleHorraires;
            set => libelleHorraires = value;
        }

        #endregion
        
        
    }
}