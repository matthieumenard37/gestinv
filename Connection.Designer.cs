namespace Gestinv
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
            this.login.Location = new System.Drawing.Point(247, 205);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(310, 45);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(247, 336);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(310, 45);
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
            this.lbl_login_esp_connexion.Location = new System.Drawing.Point(352, 150);
            this.lbl_login_esp_connexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login_esp_connexion.Name = "lbl_login_esp_connexion";
            this.lbl_login_esp_connexion.Size = new System.Drawing.Size(108, 40);
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
            this.lbl_password_esp_connexion.Location = new System.Drawing.Point(297, 281);
            this.lbl_password_esp_connexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password_esp_connexion.Name = "lbl_password_esp_connexion";
            this.lbl_password_esp_connexion.Size = new System.Drawing.Size(220, 40);
            this.lbl_password_esp_connexion.TabIndex = 3;
            this.lbl_password_esp_connexion.Text = "Mot de passe";
            this.lbl_password_esp_connexion.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(247, 431);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(310, 59);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Se connecter";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_espace_connexion
            // 
            this.lbl_espace_connexion.AutoSize = true;
            this.lbl_espace_connexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_espace_connexion.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_espace_connexion.Location = new System.Drawing.Point(160, 50);
            this.lbl_espace_connexion.Name = "lbl_espace_connexion";
            this.lbl_espace_connexion.Size = new System.Drawing.Size(497, 43);
            this.lbl_espace_connexion.TabIndex = 5;
            this.lbl_espace_connexion.Text = "ESPACE DE CONNEXION";
            this.lbl_espace_connexion.Click += new System.EventHandler(this.lbl_espaceConnexion_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 547);
            this.Controls.Add(this.lbl_espace_connexion);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_password_esp_connexion);
            this.Controls.Add(this.lbl_login_esp_connexion);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(4);
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

