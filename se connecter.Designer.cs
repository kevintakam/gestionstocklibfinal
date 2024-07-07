namespace gestiondestocklib
{
    partial class secconnecter
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
            this.p_seconnecter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_lib = new System.Windows.Forms.PictureBox();
            this.lb_gest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p_seconnecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).BeginInit();
            this.SuspendLayout();
            // 
            // p_seconnecter
            // 
            this.p_seconnecter.Image = global::gestiondestocklib.Properties.Resources.se_connecter;
            this.p_seconnecter.Location = new System.Drawing.Point(97, 100);
            this.p_seconnecter.Name = "p_seconnecter";
            this.p_seconnecter.Size = new System.Drawing.Size(293, 111);
            this.p_seconnecter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_seconnecter.TabIndex = 0;
            this.p_seconnecter.TabStop = false;
            this.p_seconnecter.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 3;
            // 
            // p_lib
            // 
            this.p_lib.Image = global::gestiondestocklib.Properties.Resources._446637_ez_Visuel_livres_en_vrac;
            this.p_lib.Location = new System.Drawing.Point(14, 21);
            this.p_lib.Name = "p_lib";
            this.p_lib.Size = new System.Drawing.Size(167, 64);
            this.p_lib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_lib.TabIndex = 2;
            this.p_lib.TabStop = false;
            // 
            // lb_gest
            // 
            this.lb_gest.AutoSize = true;
            this.lb_gest.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_gest.Location = new System.Drawing.Point(176, 41);
            this.lb_gest.Name = "lb_gest";
            this.lb_gest.Size = new System.Drawing.Size(285, 28);
            this.lb_gest.TabIndex = 4;
            this.lb_gest.Text = "GESTION DE STOCK LIB";
            // 
            // secconnecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiondestocklib.Properties.Resources.fond_blanc;
            this.ClientSize = new System.Drawing.Size(510, 253);
            this.Controls.Add(this.lb_gest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_lib);
            this.Controls.Add(this.p_seconnecter);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "secconnecter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "se connecter";
            this.Load += new System.EventHandler(this.secconnecter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_seconnecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_lib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_seconnecter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox p_lib;
        private System.Windows.Forms.Label lb_gest;
    }
}

