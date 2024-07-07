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
    public partial class supprimerproduit : Form
    {
        public supprimerproduit()
        {
            InitializeComponent();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            accueilgestionnaire accueil = new accueilgestionnaire();
            this.Visible = false;
            accueil.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            produit produit = new produit();
            this.Visible = false;
            produit.Show();
        }

        private void cb_des_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                
                string[] designation = cb_des.Text.Split(':');
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_prod, p.designation,pu,qte,img,t.id_type_prod,p.id_type_prod,t.designation from (produit p, type_prod t) where id_prod='" + designation[0] + "'and p.designation ='" + designation[1] + "' and p.id_type_prod = t.id_type_prod  ", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_des.Text = result[0].ToString() + " " + result[1].ToString();
                    tbpu.Text = result[2].ToString();
                    tbquantité.Text = result[3].ToString();
                    cb_type.Text = result[5].ToString() + " " + result[7].ToString();



                }
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void bttelecharger_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|all files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    p_image.ImageLocation = imagelocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors du telechargement du fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerproduit_Load(object sender, EventArgs e)
        {
            try
            {
                cb_type.Enabled = false;
                tbpu.Enabled = false;
                tbquantité.Enabled = false;

                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_prod, designation from produit", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_des.Items.Add(result[0].ToString() + ":" + result[1].ToString());
                }
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez annuler l'ajout d'un nouveau produit?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cb_type.Text = "";
                cb_des.Text = "";
                tbpu.Clear();
                tbquantité.Clear();
                if (MessageBox.Show("voulez vous retourner sur la page d'accueil?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    accueilgestionnaire accueil = new accueilgestionnaire();
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
            try
            {
                string[] tab = cb_des.Text.Split(':');
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("delete from produit where id_prod ='"+tab[0].ToString()+"'", connexion);
                commande.ExecuteNonQuery();
                MessageBox.Show("vos données ont bien été suprimées");
                tbquantité.Clear();
                cb_des.Text = "";
                tbpu.Clear();
                cb_type.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fournisseur fournisseur = new fournisseur();
            this.Visible = false;
            fournisseur.Show();
        }
    }
}
