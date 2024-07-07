namespace gestiondestocklib
{
    partial class identificationadmin
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
            this.p_lib = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.lbmotdepasse = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbmotdepasse = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.p_quitter = new System.Windows.Forms.PictureBox();
            this.p_connexion = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbinfo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_connexion)).BeginInit();
            this.SuspendLayout();
            // 
            // p_lib
            // 
            this.p_lib.Image = global::gestiondestocklib.Properties.Resources._446637_ez_Visuel_livres_en_vrac;
            this.p_lib.Location = new System.Drawing.Point(14, 21);
            this.p_lib.Name = "p_lib";
            this.p_lib.Size = new System.Drawing.Size(167, 64);
            this.p_lib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_lib.TabIndex = 3;
            this.p_lib.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(176, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "GESTION DE STOCK LIB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADMINISTRATEUR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 29);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestiondestocklib.Properties.Resources.empresario;
            this.pictureBox1.Location = new System.Drawing.Point(12, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.Location = new System.Drawing.Point(166, 136);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(117, 23);
            this.lblogin.TabIndex = 9;
            this.lblogin.Text = "Utilisateur:";
            // 
            // lbmotdepasse
            // 
            this.lbmotdepasse.AutoSize = true;
            this.lbmotdepasse.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmotdepasse.Location = new System.Drawing.Point(155, 186);
            this.lbmotdepasse.Name = "lbmotdepasse";
            this.lbmotdepasse.Size = new System.Drawing.Size(128, 19);
            this.lbmotdepasse.TabIndex = 10;
            this.lbmotdepasse.Text = "Mot de Passe:";
            // 
            // tblogin
            // 
            this.tblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblogin.Location = new System.Drawing.Point(311, 136);
            this.tblogin.Multiline = true;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(193, 34);
            this.tblogin.TabIndex = 11;
            // 
            // tbmotdepasse
            // 
            this.tbmotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmotdepasse.Location = new System.Drawing.Point(311, 176);
            this.tbmotdepasse.Multiline = true;
            this.tbmotdepasse.Name = "tbmotdepasse";
            this.tbmotdepasse.PasswordChar = '*';
            this.tbmotdepasse.Size = new System.Drawing.Size(193, 34);
            this.tbmotdepasse.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(321, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 19);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mot de passe oublié?";
            // 
            // p_quitter
            // 
            this.p_quitter.Image = global::gestiondestocklib.Properties.Resources.Quitter;
            this.p_quitter.Location = new System.Drawing.Point(170, 240);
            this.p_quitter.Name = "p_quitter";
            this.p_quitter.Size = new System.Drawing.Size(141, 41);
            this.p_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_quitter.TabIndex = 14;
            this.p_quitter.TabStop = false;
            this.p_quitter.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // p_connexion
            // 
            this.p_connexion.Image = global::gestiondestocklib.Properties.Resources.Connexionboutton0;
            this.p_connexion.Location = new System.Drawing.Point(325, 240);
            this.p_connexion.Name = "p_connexion";
            this.p_connexion.Size = new System.Drawing.Size(136, 41);
            this.p_connexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_connexion.TabIndex = 15;
            this.p_connexion.TabStop = false;
            this.p_connexion.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(58, 19);
            this.progressBar1.TabIndex = 16;
            // 
            // lbinfo
            // 
            this.lbinfo.AutoSize = true;
            this.lbinfo.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfo.ForeColor = System.Drawing.Color.Red;
            this.lbinfo.Location = new System.Drawing.Point(12, 261);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(0, 19);
            this.lbinfo.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(165, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "afficher mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(468, 252);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(53, 28);
            this.progressBar2.TabIndex = 20;
            this.progressBar2.Visible = false;
            // 
            // identificationadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiondestocklib.Properties.Resources.fond_blanc;
            this.ClientSize = new System.Drawing.Size(522, 293);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.p_connexion);
            this.Controls.Add(this.p_quitter);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbmotdepasse);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.lbmotdepasse);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_lib);
            this.Name = "identificationadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "identificationadmin";
            this.Load += new System.EventHandler(this.identificationadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_connexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_lib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbmotdepasse;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbmotdepasse;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox p_quitter;
        private System.Windows.Forms.PictureBox p_connexion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}