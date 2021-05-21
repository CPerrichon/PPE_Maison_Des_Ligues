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
       
        //Déclaration des listes
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
            #region  Load Tanguy
            //Remplissage des listes
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
            
            //Les Cbx pointent sur leur première valeur(= pas de valeurs NULL)
            comboBoxType.SelectedIndex = 0;
            comboBoxAtelier.SelectedIndex = 0;
            comboBoxBenevole.SelectedIndex = 2;
            
            //refresh bdd
            refreshDgvParticipant();
            
            #endregion    
        }

        
        #region Ajout Participant Tanguy
        
        private void buttonCreateParticipant_Click(object sender, EventArgs e)
        {
            string addnom = textBoxNom.Text;
            string addprenom = textBoxPrenom.Text;
            int addtype = GetIdForType(comboBoxType.SelectedItem.ToString());
            string addadresse = textBoxAdresse.Text;
            string addmail = textBoxMail.Text;
            string addnumTel = textBoxTel.Text;
            int addatelier = GetIdForAtelier(comboBoxAtelier.SelectedItem.ToString());
            int addhorraire = GetIdForHorraireBenevoles(comboBoxBenevole.SelectedItem.ToString());

            if (textBoxNom.Text.Length != 0 && textBoxPrenom.Text.Length != 0 && textBoxAdresse.Text.Length != 0 && textBoxMail.Text.Length != 0 && textBoxTel.Text.Length != 0)
            {
                if (textBoxTel.Text.Length == 10 )
                {
                    if (addhorraire == 1 && addtype == 3 || addhorraire == 2 && addtype == 3 ||
                        addhorraire == 3 && addtype == 1 || addhorraire == 3 && addtype == 2)
                    {
                        DAOParticipant.AjouterParticipant(addnom, addprenom, addtype, addadresse, addmail, addnumTel,
                            addatelier, addhorraire);
                        
                        //Message Box de validation
                        MessageBox.Show("Le participant a correctement été ajouté");
                        
                        //Clear des champs de saisis
                        textBoxAdresse.Clear();
                        textBoxMail.Clear();
                        textBoxNom.Clear();
                        textBoxPrenom.Clear();
                        textBoxTel.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'attribution des rôles","erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Le numéro de téléphone doit être composé de 10 caractères numériques","erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBoxTel.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tout les champs doivent être remplies","erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            //refresh bdd
            refreshDgvParticipant();

        }
        
        #endregion
        

        #region Evenements Utiles Tanguy
        
        //text box caractères alphabétiques seulement
        private void textBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Caractères alphabétiques seulement", "erreur", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        
        private void textBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Caractères alphabétiques seulement", "erreur", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        
            
        //text box caractères numériques seulement
        
        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Caractères numériques seulement", "erreur", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        
        //Fermeture de l'application 
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //Déconnexion du compte
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            Login reco = new Login();
            reco.Show();
        }

        #endregion
        
        
        #region méthodes supplémentaires Tanguy

        //ComboBox
        
        //Remplace la valeur string type combobox par la valeur int type correspondante
        private int GetIdForType(string type)
        {

            foreach (var t in this.LesTypesParticipants)
            {
                if (t.LibelleType == type)
                {
                    return t.IdType;
                } 
            }

            return 0;

        }
        
        //Remplace la valeur string atelier combobox par la valeur int atelier correspondante
        private int GetIdForAtelier(string atelier)
        {

            foreach (var a in this.LesAteliers)
            {
                if (a.LibelleAtelier == atelier)
                {
                    return a.NumAtelier;
                } 
            }

            return 0;

        }
        
        //Remplace la valeur string horraireB combobox par la valeur int horraireB correspondante
        private int GetIdForHorraireBenevoles(string Horraire)
        {

            foreach (var h in this.LesHorrairesBenevoles)
            {
                if (h.LibelleHorraires == Horraire)
                {
                    return h.IdHorraires;
                } 
            }

            return 0;

        }

        //DGV 
        
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

        #endregion
        
     
        #region Evenements Non-Utiles
        
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
        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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
            
           
        }
        
        #endregion


        
    }
}
