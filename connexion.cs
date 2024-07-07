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
    public partial class compte : Form
    {
        
        public compte()
        {
            InitializeComponent();
        }

        private void compte_Load(object sender, EventArgs e)
        {
            secconnecter seconnecterchild = new secconnecter();
            seconnecterchild.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            secconnecter secconnecterchild = new secconnecter();
            this.Visible = false;
            secconnecterchild.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            identificationadmin iden = new identificationadmin();
            this.Visible = false;
            iden.Show();
        }

        private void p_gestionnaire_Click(object sender, EventArgs e)
        {
            identificationgestionnaire iden = new identificationgestionnaire();
            this.Visible = false;
            iden.Show();
        }
    }
}
