﻿namespace Gestinv
{
    partial class Connection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.lbl_login_esp_connexion = new System.Windows.Forms.Label();
            this.lbl_password_esp_connexion = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_espace_connexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(185, 166);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(234, 38);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(185, 273);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(234, 38);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // lbl_login_esp_connexion
            // 
            this.lbl_login_esp_connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login_esp_connexion.AutoSize = true;
            this.lbl_login_esp_connexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_esp_connexion.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_esp_connexion.Location = new System.Drawing.Point(264, 122);
            this.lbl_login_esp_connexion.Name = "lbl_login_esp_connexion";
            this.lbl_login_esp_connexion.Size = new System.Drawing.Size(85, 31);
            this.lbl_login_esp_connexion.TabIndex = 2;
            this.lbl_login_esp_connexion.Text = "Login";
            this.lbl_login_esp_connexion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password_esp_connexion
            // 
            this.lbl_password_esp_connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password_esp_connexion.AutoSize = true;
            this.lbl_password_esp_connexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password_esp_connexion.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password_esp_connexion.Location = new System.Drawing.Point(223, 228);
            this.lbl_password_esp_connexion.Name = "lbl_password_esp_connexion";
            this.lbl_password_esp_connexion.Size = new System.Drawing.Size(173, 31);
            this.lbl_password_esp_connexion.TabIndex = 3;
            this.lbl_password_esp_connexion.Text = "Mot de passe";
            this.lbl_password_esp_connexion.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.Location = new System.Drawing.Point(185, 344);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(232, 48);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Se connecter";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_espace_connexion
            // 
            this.lbl_espace_connexion.AutoSize = true;
            this.lbl_espace_connexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_espace_connexion.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_espace_connexion.Location = new System.Drawing.Point(120, 41);
            this.lbl_espace_connexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_espace_connexion.Name = "lbl_espace_connexion";
            this.lbl_espace_connexion.Size = new System.Drawing.Size(403, 34);
            this.lbl_espace_connexion.TabIndex = 5;
            this.lbl_espace_connexion.Text = "ESPACE DE CONNEXION";
            this.lbl_espace_connexion.Click += new System.EventHandler(this.lbl_espaceConnexion_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 419);
            this.Controls.Add(this.lbl_espace_connexion);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_password_esp_connexion);
            this.Controls.Add(this.lbl_login_esp_connexion);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Connection";
            this.Text = "Connectez-vous";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label lbl_login_esp_connexion;
        private System.Windows.Forms.Label lbl_password_esp_connexion;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_espace_connexion;
    }
}

