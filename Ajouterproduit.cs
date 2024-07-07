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


namespace gestiondestocklib
{
    public partial class Ajouterproduit : Form
    {
        
        
        public Ajouterproduit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
           
            
        }

        private void button1_Click(object sender, EventArgs e)
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
            catch(Exception)
            {
                MessageBox.Show("Erreur lors du telechargement du fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            accueilgestionnaire accueil = new accueilgestionnaire();
            this.Visible = false;
            accueil.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (verifier_info(tbdesignation.Text, tbquantité.Text, tbpu.Text, cb_type.Text)==0)
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
                
                    MySqlConnection connexion = Classconnexion.getconnection();
                    string query = "INSERT INTO produit(designation,pu,qte,img,id_type_prod)VALUES('" + tbdesignation.Text.ToString() + "','" + tbpu.Text.ToString() + "','" + tbquantité.Text.ToString() + "','" + p_image.ImageLocation + "','" + tab[0].ToString() + "')";
                    MySqlCommand commande = new MySqlCommand(query, connexion);
                    commande.ExecuteNonQuery();
                    MessageBox.Show("vos données ont bien été enregistrées");
                    tbquantité.Clear();
                    tbdesignation.Clear();
                    tbpu.Clear();
                    cb_type.Text = "";
                    p_image.ImageLocation = "";
                    if(MessageBox.Show("voulez consulter le produit que vous venez d'enregistrer", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
       


        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ajouterproduit_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand("select id_type_prod, designation from type_prod",connexion);
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    cb_type.Items.Add(result[0].ToString() + " " + result[1].ToString());
                }
                result.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }
        //verifier remplissage champ
        static int verifier_info(string a, string b , string c, string d)
        {
            if(a == "" || b=="" || c== "" || d == "")
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            produit produit = new produit();
            this.Visible = false;
            produit.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez annuler l'ajout d'un nouveau produit?", "information",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                cb_type.Text = "";
                tbdesignation.Clear();
                tbpu.Clear();
                tbquantité.Clear();
                if(MessageBox.Show("voulez vous retourner sur la page d'accueil?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

        private void tbquantité_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fournisseur fournisseur = new fournisseur();
            this.Visible = false;
            fournisseur.Show();
        }
    }
}
