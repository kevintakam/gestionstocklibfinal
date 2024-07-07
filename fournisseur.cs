using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiondestocklib
{
    public partial class fournisseur : Form
    {
        public fournisseur()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = true;
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = true;
        }

        private void linkajouter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            AjouterFournisseur ajoutfournisseur = new AjouterFournisseur();
            ajoutfournisseur.Show();
        }

        private void linkmodifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Modifierfournisseur modifierfournisseur = new Modifierfournisseur();
            modifierfournisseur.Show();
        }

        private void linksupprimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Supprimerfournisseur supprimerfournisseur = new Supprimerfournisseur();
            supprimerfournisseur.Show();
        }

        private void lbconsulter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Consulterfournisseur consulterfournisseur = new Consulterfournisseur();
            consulterfournisseur.Show();
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
    }
}
