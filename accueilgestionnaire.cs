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
namespace gestiondestocklib
{
    
    public partial class accueilgestionnaire : Form
    {
        
        public accueilgestionnaire()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accueilgestionnaire_Load(object sender, EventArgs e)
        {
            // string maconnexion = "server=localhost;database=bd_stock;user id=root;pwd=";
            // MySqlConnection connexion = new MySqlConnection(maconnexion);
            linkLabel3.Enabled = false;
            linkLabel4.Enabled = false;

            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = connexion;
                commande.CommandType = CommandType.Text;
                commande.CommandText = "select count(id_prod) from produit";
                MySqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    lb_disponible.Text = result[0].ToString();
                }
                result.Close();
            
            /* MySqlCommand commande2 = new MySqlCommand();
             commande2.Connection = connexion;
             commande2.CommandType = CommandType.Text;
             commande2.CommandText= "";
             MySqlDataReader result2 = commande2.ExecuteReader();
             while (result2.Read()) {
                 lbnondisponible.Text = result2[0].ToString(); 
                   }
             result2.Close();
         */
         MySqlCommand commande3 = new MySqlCommand();
            commande3.Connection = connexion;
            commande3.CommandType = CommandType.Text;
            commande3.CommandText = "select count(id_fournisseur) from founisseur";
            MySqlDataReader result3 = commande3.ExecuteReader();
            while (result3.Read())
            {
                lb_personnel.Text = result3[0].ToString();
            }
           
            result3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Classconnexion.closeconnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            produit produit = new produit();
            this.Visible = false;
            produit.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fournisseur fournisseur = new fournisseur();
            this.Visible = false;
            fournisseur.Show();
        }
    }
}
