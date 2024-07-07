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
    public partial class accueiladministrateur : Form
    {
        public accueiladministrateur()
        {
            InitializeComponent();
        }

        private void accueiladministrateur_Load(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;
            linkLabel2.Enabled = false;
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fournisseur fournisseur = new fournisseur();
            this.Visible = false;
            fournisseur.Show();
        }
    }
}
