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
        private Atelier monAtelier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialiserAtelier();
            remplirListeAteliers();
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
        #endregion

        #region Procédures et Fonctions utilisateurs

        private void initialiserAtelier()
        {
            monAtelier = new Atelier(1, "test", 10, new DateTime(2021, 5, 6, 8, 30, 52), new DateTime(2021, 5, 6, 8, 30, 52), 1);

            monAtelier.LesAteliers = Atelier.listeAteliers();
        }

        private void remplirListeAteliers()
        {
            dgvAtelier.DataSource = null;
            dgvAtelier.DataSource = monAtelier.LesAteliers;

            // on redimensionne automatiquement la largeur des colonnes du datagridview
            dgvAtelier.AutoResizeColumns();
        }

        
    } 
        #endregion
 }

