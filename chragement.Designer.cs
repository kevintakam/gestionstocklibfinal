namespace gestiondestocklib
{
    partial class chragement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbgest = new System.Windows.Forms.Label();
            this.p_lib = new System.Windows.Forms.PictureBox();
            this.progressbar1 = new System.Windows.Forms.ProgressBar();
            this.lbchargement = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).BeginInit();
            this.SuspendLayout();
            // 
            // lbgest
            // 
            this.lbgest.AutoSize = true;
            this.lbgest.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgest.Location = new System.Drawing.Point(215, 81);
            this.lbgest.Name = "lbgest";
            this.lbgest.Size = new System.Drawing.Size(285, 28);
            this.lbgest.TabIndex = 3;
            this.lbgest.Text = "GESTION DE STOCK LIB";
            // 
            // p_lib
            // 
            this.p_lib.Image = global::gestiondestocklib.Properties.Resources._446637_ez_Visuel_livres_en_vrac;
            this.p_lib.Location = new System.Drawing.Point(52, 61);
            this.p_lib.Name = "p_lib";
            this.p_lib.Size = new System.Drawing.Size(167, 64);
            this.p_lib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_lib.TabIndex = 2;
            this.p_lib.TabStop = false;
            // 
            // progressbar1
            // 
            this.progressbar1.Location = new System.Drawing.Point(101, 148);
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(347, 54);
            this.progressbar1.TabIndex = 4;
            // 
            // lbchargement
            // 
            this.lbchargement.AutoSize = true;
            this.lbchargement.BackColor = System.Drawing.Color.Silver;
            this.lbchargement.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchargement.Location = new System.Drawing.Point(235, 160);
            this.lbchargement.Name = "lbchargement";
            this.lbchargement.Size = new System.Drawing.Size(0, 26);
            this.lbchargement.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chragement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiondestocklib.Properties.Resources.fond_blanc;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.lbchargement);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.lbgest);
            this.Controls.Add(this.p_lib);
            this.Name = "chragement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chragement";
            this.Load += new System.EventHandler(this.chragement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbgest;
        private System.Windows.Forms.PictureBox p_lib;
        private System.Windows.Forms.ProgressBar progressbar1;
        private System.Windows.Forms.Label lbchargement;
        private System.Windows.Forms.Timer timer1;
    }
}