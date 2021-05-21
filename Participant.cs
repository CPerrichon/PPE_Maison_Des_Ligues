namespace PPE_Maison_Des_Ligues
{
    public class Participant
    {
        #region Propriétés privées

        private int id;
        private string nom;
        private string prenom;
        private int idType;
        private string adresse;
        private string mail;
        private string numPortable;
        private int idAtelier;
        private int idHorraireBenevoles;


        #endregion

        #region Constructeur

        public Participant(int id, string nom, string prenom, int idType, string adresse, string mail, string numPortable, int idAtelier, int idHorraireBenevoles)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.idType = idType;
            this.adresse = adresse;
            this.mail = mail;
            this.numPortable = numPortable;
            this.idAtelier = idAtelier;
            this.idHorraireBenevoles = idHorraireBenevoles;
        }

        #endregion

        #region Accesseurs

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }

        public int IdType
        {
            get => idType;
            set => idType = value;
        }

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public string NumPortable
        {
            get => numPortable;
            set => numPortable = value;
        }

        public int IdAtelier
        {
            get => idAtelier;
            set => idAtelier = value;
        }

        public int IdHorraireBenevoles
        {
            get => idHorraireBenevoles;
            set => idHorraireBenevoles = value;
        }

        #endregion

        #region Méthodes

        

        #endregion
        
    }
}