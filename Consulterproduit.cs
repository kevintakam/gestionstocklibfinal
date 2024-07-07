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
    public partial class Consulterproduit : Form
    {
      
        public Consulterproduit()
        {
            InitializeComponent();
        }
        
        void nom_livre1( int i)
        {
            /*MySqlConnection connexion = Classconnexion.getconnection();
            MySqlCommand commande1 = new MySqlCommand("select id_prod, p.designation,pu,qte,img,t.id_type_prod,p.id_type_prod,t.designation from (produit p, type_prod t) where id_prod='"+i+"'", connexion);
            MySqlDataReader result1 = commande1.ExecuteReader();
            Label label = new Label();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            label.Name =  "lbtitre"+i;
            label1.Name = "lbprix"+i;
            label2.Name = "lbquantite"+i;
            label3.Name = "lbtype"+i;
         
            while (result1.Read())
            {               
                lbtitre1.Text = result1[1].ToString();
                lbprix1.Text = result1[2].ToString() + " F CFA";
                lbquantite1.Text = result1[3].ToString();
                lbtype1.Text = result1[7].ToString();
                
            }
            result1.Close();
            Classconnexion.closeconnection();*/
        }
       public void affiche_tab()
        {
            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                MySqlDataAdapter commande1 = new MySqlDataAdapter("select designation,pu,qte,img,des_type from produit_type", connexion);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                var ds = new DataSet();
                commande1.Fill(ds);
                dataGridprod.DataSource = ds.Tables[0];
                Classconnexion.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        private void Consulterproduit_Load(object sender, EventArgs e)
        {
            panelinfo.Visible = false;
            affiche_tab();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panelinfo.Visible = true;
            lbrechercher.Visible = true;
            /*tbdesignation.Text = dataGridprod.SelectedRows[0].Cells[1].Value.ToString();
            tbprix.Text = dataGridprod.SelectedRows[1].Cells[2].ToString();
            tbquantite.Text = dataGridprod.SelectedRows[1].Cells[3].ToString();
            tbtype.Text = dataGridprod.SelectedRows[1].Cells[5].ToString();*/


        }

        private void p_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            produit produit = new produit();
            produit.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                if (tbrecherche.Text == "") {
                    MySqlDataAdapter commande1 = new MySqlDataAdapter("select designation,pu,qte,img from produit_type", connexion);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                    var ds = new DataSet();
                    commande1.Fill(ds);
                    dataGridprod.DataSource = ds.Tables[0];
                   
                }
                else
                {
                    MySqlDataAdapter commande1 = new MySqlDataAdapter("select designation,pu,qte,img from produit_type where designation ='" + tbrecherche.Text.ToString() + "' or  pu ='" + tbrecherche.Text.ToString() + "'", connexion);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                    var ds = new DataSet();
                    commande1.Fill(ds);
                    dataGridprod.DataSource = ds.Tables[0];
                }
                Classconnexion.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbrecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connexion = Classconnexion.getconnection();
                if (tbrecherche.Text == "")
                {
                    MySqlDataAdapter commande1 = new MySqlDataAdapter("select designation,pu,qte,img from produit_type", connexion);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                    var ds = new DataSet();
                    commande1.Fill(ds);
                    dataGridprod.DataSource = ds.Tables[0];

                }
                else
                {
                    
                    string tb = tbrecherche.Text.ToString();
                    char a = tb[0];
                    MySqlDataAdapter commande1 = new MySqlDataAdapter("select designation,pu,qte,img from produit_type where designation like  '" + tbrecherche.Text.ToString() + "%' or pu like  '" + tbrecherche.Text.ToString() + "%' ", connexion);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(commande1);
                    var ds = new DataSet();
                    commande1.Fill(ds);
                    dataGridprod.DataSource = ds.Tables[0];
                }
                Classconnexion.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            modifproduit modif = new modifproduit();
            modif.Show();
        }

        private void lbrechercher_Click(object sender, EventArgs e)
        {
            lbrechercher.Visible = false;
            tbrecherche.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbrechercher.Visible = true;
        }
    }
}
