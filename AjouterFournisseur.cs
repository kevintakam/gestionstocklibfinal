using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace gestiondestocklib
{
    public partial class AjouterFournisseur : Form
    {
        public AjouterFournisseur()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fournisseur fournisseur = new fournisseur();
            this.Visible = false;
            fournisseur.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            produit produit = new produit();
            this.Visible = false;
            produit.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            accueilgestionnaire accueil = new accueilgestionnaire();
            this.Visible = false;
            accueil.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (verifier_info(tbnom.Text, tbprenom.Text, tbtel.Text,tbemail.Text) == 0)
            {
                timer1.Enabled = true;
                lbinfo.Text = "veuillez remplir tous les champs";
            }
            else
            {
                timer1.Enabled = true;
                lbinfo.Text = "les champs sont remplis";
                lbinfo.ForeColor = Color.Green;
                try
                {

                    MySqlConnection connexion = Classconnexion.getconnection();
                    string query = "INSERT INTO founisseur(nom,prenom,telephone,Email)VALUES('" + tbnom.Text.ToString() + "','" + tbprenom.Text.ToString() + "','" + tbtel.Text.ToString() + "','" + tbemail.Text.ToString() + "')";


                    MySqlCommand commande = new MySqlCommand(query, connexion);
                    commande.ExecuteNonQuery();
                    MessageBox.Show("vos données ont bien été enregistrées");
                    tbnom.Clear();
                    tbprenom.Clear();
                    tbtel.Clear();
                    tbemail.Clear();
                   
                    if (MessageBox.Show("voulez consulter la liste de fournisseurs","information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Visible = false;
                        Consulterfournisseur consulterfournisseur = new Consulterfournisseur();
                        consulterfournisseur.Show();
                        
                    }
                    else
                    {
                        this.Visible = true;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }





            }

        }

        //verifier remplissage champ
        static int verifier_info(string a, string b, string c, string d)
        {
            if (a == "" || b == "" || c == "" || d == "")
            {
                return 0;
            }
            else
            {
                return 1;
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

        private void tbtel_TextChanged(object sender, EventArgs e)
        {
               
        }
        public static bool IsValidPhoneNumber(string phoneNumber)

        {
            //will match +61 or +61- or 0 or nothing followed by a nine digit number
            return Regex.Match(phoneNumber,
                 @"^([\+]?237[-]?|[0])?6[5-9][0-9]{7}$").Success;

            //     @"^([\+]?61[-]?|[0])?[1-9][0-9]{8}$").Success;
            //to vary this, replace 61 with an international code of your choice 
            //or remove [\+]?61[-]? if international code isn't needed
            //{8} is the number of digits in the actual phone number less one
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("voulez annuler l'ajout d'un nouveau fournisseur?","information",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

            {
                
                tbemail.Clear();
                tbnom.Clear();
                tbprenom.Clear();
                tbtel.Clear();
             
                if(MessageBox.Show("voulez vous retourner sur la page d'accueil?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Visible = false;
                    accueiladministrateur accueil = new accueiladministrateur();
                    accueil.Show();
                }
                else
                {
                    this.Visible = true;
                }
            }
            else
            {
                this.Visible = true;
            }
        }

        private void AjouterFournisseur_Load(object sender, EventArgs e)
        {

        }
    }

}
