using System;
using System.Linq;
using System.Windows.Forms;

namespace PPE_Maison_Des_Ligues
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txbIdentifiant_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }


        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string identifiant = txbIdentifiant.Text;
            string mdp = txbmdp.Text;

            bool conn = Connect.seConnecter(identifiant, mdp);

            if (txbIdentifiant.Text.Length==0 && txbmdp.Text.Length==0)
            {
                MessageBox.Show("Entrez un nom d'utilisateur et un mot de passe","erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (conn == true) //Instruction si conn est vrai 
                {
                    this.Hide(); //Cache le form Login 
                    Form1 APPLI_PPE = new Form1();//Création Obj Form1 APPLI_PPE
                    APPLI_PPE.Show();//Ouvre le Form APPLI_PPE
                }
                else
                {
                    MessageBox.Show("Le nom d'utilisateur ou le mot de passe est faux","erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}