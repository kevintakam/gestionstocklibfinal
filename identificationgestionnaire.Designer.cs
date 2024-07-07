namespace gestiondestocklib
{
    partial class identificationgestionnaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbmotdepasse = new System.Windows.Forms.TextBox();
            this.lbmotdepassoublie = new System.Windows.Forms.LinkLabel();
            this.p_quitter = new System.Windows.Forms.PictureBox();
            this.p_connexion = new System.Windows.Forms.PictureBox();
            this.lbinfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.p_lib.Location = new System.Drawing.Point(13, 21);
            this.p_lib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_lib.Name = "p_lib";
            this.p_lib.Size = new System.Drawing.Size(167, 64);
            this.p_lib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_lib.TabIndex = 4;
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
            this.label2.TabIndex = 6;
            this.label2.Text = "GESTION DE STOCK LIB";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 30);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "GESTIONNAIRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestiondestocklib.Properties.Resources.empresario;
            this.pictureBox1.Location = new System.Drawing.Point(12, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Utilisateur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mot de Passe:";
            // 
            // tblogin
            // 
            this.tblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblogin.Location = new System.Drawing.Point(311, 135);
            this.tblogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblogin.Multiline = true;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(193, 34);
            this.tblogin.TabIndex = 12;
            // 
            // tbmotdepasse
            // 
            this.tbmotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmotdepasse.Location = new System.Drawing.Point(311, 176);
            this.tbmotdepasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmotdepasse.Multiline = true;
            this.tbmotdepasse.Name = "tbmotdepasse";
            this.tbmotdepasse.PasswordChar = '*';
            this.tbmotdepasse.Size = new System.Drawing.Size(193, 34);
            this.tbmotdepasse.TabIndex = 13;
            // 
            // lbmotdepassoublie
            // 
            this.lbmotdepassoublie.AutoSize = true;
            this.lbmotdepassoublie.DisabledLinkColor = System.Drawing.Color.White;
            this.lbmotdepassoublie.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmotdepassoublie.Location = new System.Drawing.Point(321, 213);
            this.lbmotdepassoublie.Name = "lbmotdepassoublie";
            this.lbmotdepassoublie.Size = new System.Drawing.Size(183, 19);
            this.lbmotdepassoublie.TabIndex = 14;
            this.lbmotdepassoublie.TabStop = true;
            this.lbmotdepassoublie.Text = "Mot de passe oublié?";
            // 
            // p_quitter
            // 
            this.p_quitter.Image = global::gestiondestocklib.Properties.Resources.Quitter;
            this.p_quitter.Location = new System.Drawing.Point(171, 240);
            this.p_quitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_quitter.Name = "p_quitter";
            this.p_quitter.Size = new System.Drawing.Size(141, 41);
            this.p_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_quitter.TabIndex = 15;
            this.p_quitter.TabStop = false;
            this.p_quitter.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // p_connexion
            // 
            this.p_connexion.Image = global::gestiondestocklib.Properties.Resources.Connexionboutton0;
            this.p_connexion.Location = new System.Drawing.Point(325, 240);
            this.p_connexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_connexion.Name = "p_connexion";
            this.p_connexion.Size = new System.Drawing.Size(136, 41);
            this.p_connexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_connexion.TabIndex = 16;
            this.p_connexion.TabStop = false;
            this.p_connexion.Click += new System.EventHandler(this.p_connexion_Click);
            // 
            // lbinfo
            // 
            this.lbinfo.AutoSize = true;
            this.lbinfo.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfo.ForeColor = System.Drawing.Color.Red;
            this.lbinfo.Location = new System.Drawing.Point(12, 261);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(0, 19);
            this.lbinfo.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 1);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(59, 18);
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(469, 250);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(53, 28);
            this.progressBar2.TabIndex = 18;
            this.progressBar2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(165, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 20);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "afficher mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // identificationgestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiondestocklib.Properties.Resources.fond_blanc;
            this.ClientSize = new System.Drawing.Size(523, 293);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.p_connexion);
            this.Controls.Add(this.p_quitter);
            this.Controls.Add(this.lbmotdepassoublie);
            this.Controls.Add(this.tbmotdepasse);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_lib);
            this.Location = new System.Drawing.Point(170, 240);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "identificationgestionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "identificationgestionnaire";
            this.Load += new System.EventHandler(this.identificationgestionnaire_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbmotdepasse;
        private System.Windows.Forms.LinkLabel lbmotdepassoublie;
        private System.Windows.Forms.PictureBox p_quitter;
        private System.Windows.Forms.PictureBox p_connexion;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}