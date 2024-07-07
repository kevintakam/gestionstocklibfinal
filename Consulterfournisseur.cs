using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace gestiondestocklib
{
    public partial class Consulterfournisseur : Form
    {
        public Consulterfournisseur()
        {
            InitializeComponent();
        }
        public void afficher_tab()
        {
            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlDataAdapter commande1 = new MySqlDataAdapter("select nom,prenom,telephone,email from founisseur", connexion);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                var ds = new DataSet();
                commande1.Fill(ds);
                dataGridfour.DataSource = ds.Tables[0];
                Classconnexion.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Consulterfournisseur_Load(object sender, EventArgs e)
        {
            afficher_tab();
            lbrechercher.Visible = true;
        }

        private void tbrecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                if (tbrecherche.Text == "")
                {
                    MySqlDataAdapter commande1 = new MySqlDataAdapter("select nom,prenom,telephone,email from founisseur", connexion);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                    var ds = new DataSet();
                    commande1.Fill(ds);
                    dataGridfour.DataSource = ds.Tables[0];

                }
                else
                {

                    string tb = tbrecherche.Text.ToString();
                    char a = tb[0];
                    MySqlDataAdapter commande1 = new MySqlDataAdapter("select nom,prenom,telephone,email from founisseur where nom like  '" + tbrecherche.Text.ToString() + "%' or telephone like  '" + tbrecherche.Text.ToString() + "%' ", connexion);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                    var ds = new DataSet();
                    commande1.Fill(ds);
                    dataGridfour.DataSource = ds.Tables[0];
                }
                Classconnexion.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void lbrechercher_Click(object sender, EventArgs e)
        {
            lbrechercher.Visible = false;
            tbrecherche.Focus();
        }

        private void dataGridfour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbrechercher.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbrechercher.Visible = true;
        }
    }
}
