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
    public partial class modifproduit : Form
    {
        public modifproduit()
        {
            InitializeComponent();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            accueilgestionnaire accueil = new accueilgestionnaire();
            this.Visible = false;
            accueil.Show();
        }

        private void modifproduit_Load(object sender, EventArgs e)
        {
            try
            {
                cb_type.Enabled = false;
                tbpu.Enabled = false;
                tbquantité.Enabled = false;
                bttelecharger.Enabled = false;
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_prod, designation from produit", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_des.Items.Add(result[0].ToString() + ":" + result[1].ToString());
                }
                result.Close();
                MySqlCommand commande2 = new MySqlCommand("select id_type_prod, designation from type_prod", connexion);
                MySqlDataReader result2 = commande2.ExecuteReader();
                while (result2.Read())
                {
                    cb_type.Items.Add(result2[0].ToString() + "" + result2[1].ToString());
                }
                result2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void cb_des_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cb_type.Enabled = true;
                tbpu.Enabled = true;
                tbquantité.Enabled =true;
                bttelecharger.Enabled = true;
                string[] designation = cb_des.Text.Split(':');
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_prod, p.designation,pu,qte,img,t.id_type_prod,p.id_type_prod,t.designation from (produit p, type_prod t) where id_prod='"+designation[0]+"'and p.designation ='"+designation[1]+"' and p.id_type_prod = t.id_type_prod  ", connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_des.Text =result[0].ToString() + " " + result[1].ToString();
                    tbpu.Text = result[2].ToString();
                    tbquantité.Text = result[3].ToString();
                    cb_type.Text = result[5].ToString() + " " + result[7].ToString();
                    /*string image = result[4].ToString();
                    byte[] im = Encoding.Unicode.GetBytes(image);
                    MemoryStream ms = new MemoryStream(im, 0, im.Length);
                    ms.Write(im, 0, im.Length);
                    Image images = Image.FromStream(ms, true, true);
                    p_image.ImageLocation = ; */                        
                    
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            produit produit = new produit();
            this.Visible = false;
            produit.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez annuler l'ajout d'un nouveau produit?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cb_type.Text = "";
                cb_des.Text="";
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
        // verifier champs
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (verifier_info(cb_des.Text, tbquantité.Text, tbpu.Text, cb_type.Text) == 0)
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
                    string[] tab = cb_type.Text.Split(' ');
                    string[] tab2 = cb_des.Text.Split(':');
                    MySqlConnection connexion = Classconnexion.getconnection();
                    string query = "update produit set designation = '"+tab2[1].ToString()+"', pu = '"+tbpu.Text.ToString()+"',qte='"+tbquantité.Text.ToString()+"',id_type_prod='"+tab[0].ToString()+"' where id_prod='"+tab2[0].ToString()+"'";
                    MySqlCommand commande = new MySqlCommand(query, connexion);
                    commande.ExecuteNonQuery();
                    MessageBox.Show("vos données ont bien été modifiées");
                    tbquantité.Clear();
                    cb_des.Text ="";
                    tbpu.Clear();
                    cb_type.Text = "";
                    p_image.ImageLocation = "";
                    if (MessageBox.Show("voulez consulter le produit que vous venez d'enregistrer", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fournisseur fournisseur = new fournisseur();
            this.Visible = false;
            fournisseur.Show();
        }
    }
   }

