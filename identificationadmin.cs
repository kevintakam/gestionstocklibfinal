using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace gestiondestocklib
{
    public partial class identificationadmin : Form
    {
        public identificationadmin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("voulez vous retourner à la page de sélection de compte ?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                this.Visible = true;
            else
            {
                this.Visible = false;
                compte compte = new compte();
                compte.Show();
            }
        }
        static int taillemotdepass(string a)
        {
            if (a.Length < 8)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            MySqlConnection connexion = new MySqlConnection("server=localhost;database=bd_stock;user id=root;pwd=");

            if (verifier_info(tblogin.Text, tbmotdepasse.Text) == 0)
            {
                timer1.Enabled = true;
                lbinfo.Text = "veuillez remplir tous les champs";
            }
            else {

                int taille = taillemotdepass(tbmotdepasse.Text);
                if (taille == 0)
                {
                    timer1.Enabled = true;
                    lbinfo.Text = "entrer au moins  8 caractère";

                }
                else {
                    connexion.Open();
                    MySqlCommand commande = new MySqlCommand();
                    commande.Connection = connexion;
                    commande.CommandType = CommandType.Text;
                    commande.CommandText = "select login, pasword, priv from compte where priv =1";
                    MySqlDataReader lecteur;
                    lecteur = commande.ExecuteReader();
                    tblogin.Text = tblogin.Text.ToLower();
                    tbmotdepasse.Text = tbmotdepasse.Text.ToLower();
                    while (lecteur.Read())
                    {
                        if (tblogin.Text == lecteur[0].ToString() && tbmotdepasse.Text == lecteur[1].ToString())
                        {
                            if (MessageBox.Show("patientez quelques secondes", "information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                            {
                                this.Visible = false;
                                timer2.Enabled = true;
                                accueiladministrateur accueil = new accueiladministrateur();
                                accueil.Show();
                                tblogin.Text = lecteur[0].ToString();
                            }

                        }
                        else
                        {
                            MessageBox.Show("vos données que vous avez entrée sont incorrectes", "information", MessageBoxButtons.OK);
                        }


                    }
                    lecteur.Close();

                }


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                lbinfo.Text = "";
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
            else
            {
                progressBar1.Value += 1;
            }

        }

        private void identificationadmin_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }
        //verifier les informations entrees
        static int verifier_info(string a, string b)
        {
            if (a == "" || b == "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbmotdepasse.PasswordChar ='\0';
            }
            else
            {
                tbmotdepasse.PasswordChar = '*';
            }
            
        }
    }
}
