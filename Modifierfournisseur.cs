using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace gestiondestocklib
{
    public partial class Modifierfournisseur : Form
    {
        public Modifierfournisseur()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez annuler la modification de ce fournisseur?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cb_four.Text = " ";
                tbemail.Clear();
                tbtel.Clear();
                tbprenom.Clear();

                if (MessageBox.Show("voulez vous retourner sur la page d'accueil?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (verifier_info(cb_four.Text, tbprenom.Text, tbemail.Text, tbtel.Text) == 0)
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
                    
                    string[] tab2 = cb_four.Text.Split(':');
                    MySqlConnection connexion = Classconnexion.getconnection();
                    string query = "update founisseur set nom = '" + tab2[1].ToString() + "', prenom = '" + tbprenom.Text.ToString() + "',telephone='" + tbtel.Text.ToString() + "',email='" + tbemail.Text.ToString() + "' where id_fournisseur='" + tab2[0].ToString() + "'";
                    MySqlCommand commande = new MySqlCommand(query, connexion);
                    commande.ExecuteNonQuery();
                    MessageBox.Show("vos données ont bien été modifiées");
                    cb_four.Text = " ";
                    tbemail.Clear();
                    tbtel.Clear();
                    tbprenom.Clear();
                    if (MessageBox.Show("voulez consulter le fournisseur que vous venez d'enregistrer", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Visible = false;
                        Consulterproduit consulterproduit = new Consulterproduit();
                        consulterproduit.Show();
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

        private void Modifierfournisseur_Load(object sender, EventArgs e)
        {
            try
            {
                
                tbprenom.Enabled = false;
                tbemail.Enabled = false;
                tbtel.Enabled = false;
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_fournisseur, nom from founisseur", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_four.Items.Add(result[0].ToString() + ":" + result[1].ToString());
                }
                result.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void cb_four_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                tbemail.Enabled = true;
                tbprenom.Enabled = true;
                tbtel.Enabled = true;
               
                string[] nom = cb_four.Text.Split(':');
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_fournisseur, nom,prenom,email,telephone from (founisseur) where id_fournisseur='"+nom[0]+"' and nom ='"+nom[1]+"'  ", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_four.Text = result[0].ToString() + " " + result[1].ToString();
                    tbprenom.Text = result[2].ToString();
                    tbemail.Text = result[3].ToString();
                    tbtel.Text = result[4].ToString();
                   

                }
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }
    }
    
}
