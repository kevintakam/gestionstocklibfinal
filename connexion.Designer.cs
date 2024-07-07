namespace gestiondestocklib
{
    partial class compte
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
            this.p_lib = new System.Windows.Forms.PictureBox();
            this.lbgest = new System.Windows.Forms.Label();
            this.p_admin = new System.Windows.Forms.PictureBox();
            this.p_gestionnaire = new System.Windows.Forms.PictureBox();
            this.p_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_gestionnaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_back)).BeginInit();
            this.SuspendLayout();
            // 
            // p_lib
            // 
            this.p_lib.Image = global::gestiondestocklib.Properties.Resources._446637_ez_Visuel_livres_en_vrac;
            this.p_lib.Location = new System.Drawing.Point(26, 37);
            this.p_lib.Name = "p_lib";
            this.p_lib.Size = new System.Drawing.Size(167, 64);
            this.p_lib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_lib.TabIndex = 0;
            this.p_lib.TabStop = false;
            // 
            // lbgest
            // 
            this.lbgest.AutoSize = true;
            this.lbgest.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgest.Location = new System.Drawing.Point(189, 57);
            this.lbgest.Name = "lbgest";
            this.lbgest.Size = new System.Drawing.Size(285, 28);
            this.lbgest.TabIndex = 1;
            this.lbgest.Text = "GESTION DE STOCK LIB";
            // 
            // p_admin
            // 
            this.p_admin.Image = global::gestiondestocklib.Properties.Resources.admin;
            this.p_admin.Location = new System.Drawing.Point(71, 129);
            this.p_admin.Name = "p_admin";
            this.p_admin.Size = new System.Drawing.Size(177, 81);
            this.p_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_admin.TabIndex = 2;
            this.p_admin.TabStop = false;
            this.p_admin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // p_gestionnaire
            // 
            this.p_gestionnaire.Image = global::gestiondestocklib.Properties.Resources.gestionnaire;
            this.p_gestionnaire.Location = new System.Drawing.Point(264, 128);
            this.p_gestionnaire.Name = "p_gestionnaire";
            this.p_gestionnaire.Size = new System.Drawing.Size(210, 81);
            this.p_gestionnaire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_gestionnaire.TabIndex = 3;
            this.p_gestionnaire.TabStop = false;
            this.p_gestionnaire.Click += new System.EventHandler(this.p_gestionnaire_Click);
            // 
            // p_back
            // 
            this.p_back.Image = global::gestiondestocklib.Properties.Resources.previous;
            this.p_back.Location = new System.Drawing.Point(466, 215);
            this.p_back.Name = "p_back";
            this.p_back.Size = new System.Drawing.Size(50, 45);
            this.p_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_back.TabIndex = 4;
            this.p_back.TabStop = false;
            this.p_back.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiondestocklib.Properties.Resources.fond_blanc;
            this.ClientSize = new System.Drawing.Size(514, 257);
            this.Controls.Add(this.p_back);
            this.Controls.Add(this.p_gestionnaire);
            this.Controls.Add(this.p_admin);
            this.Controls.Add(this.lbgest);
            this.Controls.Add(this.p_lib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "compte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "connexion";
            this.Load += new System.EventHandler(this.compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_gestionnaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_lib;
        private System.Windows.Forms.Label lbgest;
        private System.Windows.Forms.PictureBox p_admin;
        private System.Windows.Forms.PictureBox p_gestionnaire;
        private System.Windows.Forms.PictureBox p_back;
    }
}