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
    public partial class chragement : Form
    {
        public chragement()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressbar1.Value == 100)
            {
                progressbar1.Value = 0;
                timer1.Enabled = false;
                compte connex = new compte();
                connex.Show(); 
                
               
            }
            else
            {
                progressbar1.Value += 1;
                lbchargement.Text = progressbar1.Value + " %";
            }

        }

        private void chragement_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
