using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Maison_Des_Ligues
{
    public class TypeParticipant
    {
        #region Propriétés privées

        private int idType;
        private string libelleType;

        #endregion

        #region Constructeur

        public TypeParticipant(int idType, string libelleType)
        {
            this.idType = idType;
            this.libelleType = libelleType;
        }

        #endregion

        #region Accesseurs

        public int IdType
        {
            get => idType;
            set => idType = value;
        }

        public string LibelleType
        {
            get => libelleType;
            set => libelleType = value;
        }

        #endregion
    }
}