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
    public partial class Supprimerfournisseur : Form
    {
        public Supprimerfournisseur()
        {
            InitializeComponent();
        }

        private void lb_produit_Click(object sender, EventArgs e)
        {

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
            if (MessageBox.Show("voulez annuler la suppression de ce fournisseur?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

            {
                cb_four.Text = " ";
                
                tbemail.Clear();
                textBox1.Clear();
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

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] tab = cb_four.Text.Split(':');
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("delete from founisseur where id_fournisseur='" + tab[0].ToString() + "'", connexion);
                commande.ExecuteNonQuery();
                MessageBox.Show("vos données ont bien été suprimées");
               
                tbemail.Clear();
                tbprenom.Clear();
                textBox1.Clear();
                cb_four.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void Supprimerfournisseur_Load(object sender, EventArgs e)
        {
            try
            {
                 tbemail.Enabled = false;
                tbprenom.Enabled = false;
                textBox1.Enabled = false;

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
                textBox1.Enabled = true;

                string[] nom = cb_four.Text.Split(':');
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_fournisseur, nom,prenom,email,telephone from (founisseur) where id_fournisseur='" + nom[0] + "' and nom ='" + nom[1] + "'  ", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_four.Text = result[0].ToString() + " " + result[1].ToString();
                    tbprenom.Text = result[2].ToString();
                    tbemail.Text = result[3].ToString();
                    textBox1.Text = result[4].ToString();


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
