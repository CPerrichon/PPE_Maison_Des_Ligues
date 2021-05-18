using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Maison_Des_Ligues
{
    public partial class Form1 : Form
    {
        public List<Atelier> LesAteliers = new List<Atelier>();
        public List<HorrairesBenevoles> LesHorrairesBenevoles = new List<HorrairesBenevoles>();
        public List<TypeParticipant> LesTypesParticipants = new List<TypeParticipant>();
        public List<Participant> LesParticipants = new List<Participant>();

        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

            LesAteliers = DAOAtelier.getAllAteliers();
            LesHorrairesBenevoles = DAOHorrairesBenevoles.getAllHorrairesBenevoles();
            LesTypesParticipants = DAOTypeParticipant.getAllTypeParticipants();
            
            //Affichage de tout les Ateliers existants dans la bdd dans comboBoxAtelier
            foreach (var a in LesAteliers)
            {
                comboBoxAtelier.Items.Add(a.LibelleAtelier);
            }
            
            //Affichage de tout les Horraires Benevoles existants dans la bdd dans comboBoxBenevole
            foreach (var h in LesHorrairesBenevoles)
            {
                comboBoxBenevole.Items.Add(h.LibelleHorraires);
            }
            
            //Affichage de tout les Types Participants existants dans la bdd dans comboBoxType
            foreach (var t in LesTypesParticipants)
            {
                comboBoxType.Items.Add(t.LibelleType);
            }

            refreshDgvParticipant();

        }
        #region Evenements
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonCreateParticipant_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBenevole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        
        private void dgvParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            LesParticipants = DAOParticipant.getAllParticipants();

            foreach (var p in LesParticipants)
            {
                dgvParticipant.Rows.Add(p.Id,p.Nom,p.Prenom,p.IdType,p.Adresse,p.Mail,p.NumPortable,p.IdAtelier,p.IdHorraireBenevoles);
            }
        }
        
        #endregion
        
        public void refreshDgvParticipant()
        {
            dgvParticipant.Rows.Clear();
            List<Participant> LesParticipants = DAOParticipant.getAllParticipants();

            foreach (var p in LesParticipants)
            {
                dgvParticipant.Rows.Add(p.Id,p.Nom,p.Prenom, GetLibForType(p.IdType),p.Adresse,p.Mail,p.NumPortable,GetLibForAtelier(p.IdAtelier),GetLibForHorraireBenevoles(p.IdHorraireBenevoles));
            }
        }
        
        //Remplacer dans le dgv idType par LibelleType
        private string GetLibForType(int type)
        {

            foreach (var t in this.LesTypesParticipants)
            {
                if (t.IdType == type)
                {
                    return t.LibelleType;
                } 
            }

            return "Type Inexistant";
        }
        
        //Remplacer dans le dgv idAtelier par LibelleAtelier
        private string GetLibForAtelier(int atelier)
        {

            foreach (var a in this.LesAteliers)
            {
                if ( a.NumAtelier== atelier)
                {
                    return a.LibelleAtelier;
                } 
            }

            return "Atelier Inexistant";
        }
        
        //Remplacer dans le dgv idHorraire par LibelleHorraire
        private string GetLibForHorraireBenevoles(int Horraire)
        {

            foreach (var h in this.LesHorrairesBenevoles)
            {
                if (h.IdHorraires == Horraire)
                {
                    return h.LibelleHorraires;
                } 
            }

            return "Horraire Inexistante";
        }
    }
}
