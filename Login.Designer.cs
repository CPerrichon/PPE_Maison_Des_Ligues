using System.ComponentModel;

namespace PPE_Maison_Des_Ligues
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbIdentifiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbIdentifiant
            // 
            this.txbIdentifiant.Location = new System.Drawing.Point(90, 183);
            this.txbIdentifiant.Name = "txbIdentifiant";
            this.txbIdentifiant.Size = new System.Drawing.Size(253, 26);
            this.txbIdentifiant.TabIndex = 0;
            this.txbIdentifiant.TextChanged += new System.EventHandler(this.txbIdentifiant_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(90, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(428, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe:";
            // 
            // txbmdp
            // 
            this.txbmdp.Location = new System.Drawing.Point(428, 183);
            this.txbmdp.Name = "txbmdp";
            this.txbmdp.Size = new System.Drawing.Size(253, 26);
            this.txbmdp.TabIndex = 2;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(254, 302);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(270, 100);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbmdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbIdentifiant);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnConnexion;

        private System.Windows.Forms.TextBox txbIdentifiant;
        private System.Windows.Forms.TextBox txbmdp;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;

        #endregion
    }
}