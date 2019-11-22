namespace Gestinv
{
    partial class Stock_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_user));
            this.input_family = new System.Windows.Forms.ComboBox();
            this.input_article = new System.Windows.Forms.ComboBox();
            this.input_quantity = new System.Windows.Forms.TextBox();
            this.btn_inventaire_save = new System.Windows.Forms.Button();
            this.btn_inventaire_add_article = new System.Windows.Forms.Button();
            this.lbl_gestion_inventaire = new System.Windows.Forms.Label();
            this.btn_inventaire_deconnect = new System.Windows.Forms.Button();
            this.btn_synchro = new System.Windows.Forms.Button();
            this.lbl_family = new System.Windows.Forms.Label();
            this.lbl_article = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_inventaire_liste_modif = new System.Windows.Forms.Label();
            this.dtgv_inventaire_liste_modif = new System.Windows.Forms.DataGridView();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_inventaire_liste_modif)).BeginInit();
            this.SuspendLayout();
            // 
            // input_family
            // 
            this.input_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_family.FormattingEnabled = true;
            this.input_family.Location = new System.Drawing.Point(170, 124);
            this.input_family.Margin = new System.Windows.Forms.Padding(4);
            this.input_family.Name = "input_family";
            this.input_family.Size = new System.Drawing.Size(481, 46);
            this.input_family.TabIndex = 0;
            // 
            // input_article
            // 
            this.input_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_article.FormattingEnabled = true;
            this.input_article.Location = new System.Drawing.Point(170, 208);
            this.input_article.Margin = new System.Windows.Forms.Padding(4);
            this.input_article.Name = "input_article";
            this.input_article.Size = new System.Drawing.Size(481, 46);
            this.input_article.TabIndex = 1;
            // 
            // input_quantity
            // 
            this.input_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_quantity.Location = new System.Drawing.Point(170, 284);
            this.input_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.input_quantity.Name = "input_quantity";
            this.input_quantity.Size = new System.Drawing.Size(230, 45);
            this.input_quantity.TabIndex = 2;
            // 
            // btn_inventaire_save
            // 
            this.btn_inventaire_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventaire_save.Location = new System.Drawing.Point(427, 286);
            this.btn_inventaire_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inventaire_save.Name = "btn_inventaire_save";
            this.btn_inventaire_save.Size = new System.Drawing.Size(224, 43);
            this.btn_inventaire_save.TabIndex = 3;
            this.btn_inventaire_save.Text = "Enregistrer";
            this.btn_inventaire_save.UseVisualStyleBackColor = true;
            // 
            // btn_inventaire_add_article
            // 
            this.btn_inventaire_add_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventaire_add_article.Location = new System.Drawing.Point(675, 206);
            this.btn_inventaire_add_article.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inventaire_add_article.Name = "btn_inventaire_add_article";
            this.btn_inventaire_add_article.Size = new System.Drawing.Size(52, 48);
            this.btn_inventaire_add_article.TabIndex = 4;
            this.btn_inventaire_add_article.Text = "+";
            this.btn_inventaire_add_article.UseVisualStyleBackColor = true;
            // 
            // lbl_gestion_inventaire
            // 
            this.lbl_gestion_inventaire.AutoSize = true;
            this.lbl_gestion_inventaire.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gestion_inventaire.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestion_inventaire.Location = new System.Drawing.Point(162, 45);
            this.lbl_gestion_inventaire.Name = "lbl_gestion_inventaire";
            this.lbl_gestion_inventaire.Size = new System.Drawing.Size(496, 43);
            this.lbl_gestion_inventaire.TabIndex = 8;
            this.lbl_gestion_inventaire.Text = "GESTION D\'INVENTAIRE";
            this.lbl_gestion_inventaire.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_inventaire_deconnect
            // 
            this.btn_inventaire_deconnect.Location = new System.Drawing.Point(675, 12);
            this.btn_inventaire_deconnect.Name = "btn_inventaire_deconnect";
            this.btn_inventaire_deconnect.Size = new System.Drawing.Size(133, 43);
            this.btn_inventaire_deconnect.TabIndex = 9;
            this.btn_inventaire_deconnect.Text = "Déconnexion";
            this.btn_inventaire_deconnect.UseVisualStyleBackColor = true;
            // 
            // btn_synchro
            // 
            this.btn_synchro.Location = new System.Drawing.Point(675, 286);
            this.btn_synchro.Name = "btn_synchro";
            this.btn_synchro.Size = new System.Drawing.Size(133, 43);
            this.btn_synchro.TabIndex = 10;
            this.btn_synchro.Text = "Synchronisation";
            this.btn_synchro.UseVisualStyleBackColor = true;
            // 
            // lbl_family
            // 
            this.lbl_family.AutoSize = true;
            this.lbl_family.BackColor = System.Drawing.Color.Transparent;
            this.lbl_family.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_family.Location = new System.Drawing.Point(44, 133);
            this.lbl_family.Name = "lbl_family";
            this.lbl_family.Size = new System.Drawing.Size(111, 31);
            this.lbl_family.TabIndex = 11;
            this.lbl_family.Text = "Famille";
            // 
            // lbl_article
            // 
            this.lbl_article.AutoSize = true;
            this.lbl_article.BackColor = System.Drawing.Color.Transparent;
            this.lbl_article.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_article.Location = new System.Drawing.Point(52, 217);
            this.lbl_article.Name = "lbl_article";
            this.lbl_article.Size = new System.Drawing.Size(103, 31);
            this.lbl_article.TabIndex = 12;
            this.lbl_article.Text = "Article";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quantity.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(31, 293);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(124, 31);
            this.lbl_quantity.TabIndex = 13;
            this.lbl_quantity.Text = "Quantité";
            // 
            // lbl_inventaire_liste_modif
            // 
            this.lbl_inventaire_liste_modif.AutoSize = true;
            this.lbl_inventaire_liste_modif.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inventaire_liste_modif.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventaire_liste_modif.Location = new System.Drawing.Point(227, 386);
            this.lbl_inventaire_liste_modif.Name = "lbl_inventaire_liste_modif";
            this.lbl_inventaire_liste_modif.Size = new System.Drawing.Size(376, 30);
            this.lbl_inventaire_liste_modif.TabIndex = 14;
            this.lbl_inventaire_liste_modif.Text = "LISTE DES MODIFICATIONS";
            // 
            // dtgv_inventaire_liste_modif
            // 
            this.dtgv_inventaire_liste_modif.AllowUserToDeleteRows = false;
            this.dtgv_inventaire_liste_modif.AllowUserToOrderColumns = true;
            this.dtgv_inventaire_liste_modif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_inventaire_liste_modif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Family,
            this.Article,
            this.Quantity});
            this.dtgv_inventaire_liste_modif.Location = new System.Drawing.Point(196, 435);
            this.dtgv_inventaire_liste_modif.Name = "dtgv_inventaire_liste_modif";
            this.dtgv_inventaire_liste_modif.ReadOnly = true;
            this.dtgv_inventaire_liste_modif.RowHeadersWidth = 51;
            this.dtgv_inventaire_liste_modif.RowTemplate.Height = 24;
            this.dtgv_inventaire_liste_modif.Size = new System.Drawing.Size(428, 174);
            this.dtgv_inventaire_liste_modif.TabIndex = 15;
            // 
            // Family
            // 
            this.Family.HeaderText = "Famille";
            this.Family.MinimumWidth = 6;
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            this.Family.Width = 125;
            // 
            // Article
            // 
            this.Article.HeaderText = "Article";
            this.Article.MinimumWidth = 6;
            this.Article.Name = "Article";
            this.Article.ReadOnly = true;
            this.Article.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantité";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Stock_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 621);
            this.Controls.Add(this.dtgv_inventaire_liste_modif);
            this.Controls.Add(this.lbl_inventaire_liste_modif);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_article);
            this.Controls.Add(this.lbl_family);
            this.Controls.Add(this.btn_synchro);
            this.Controls.Add(this.btn_inventaire_deconnect);
            this.Controls.Add(this.lbl_gestion_inventaire);
            this.Controls.Add(this.btn_inventaire_add_article);
            this.Controls.Add(this.btn_inventaire_save);
            this.Controls.Add(this.input_quantity);
            this.Controls.Add(this.input_article);
            this.Controls.Add(this.input_family);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock_user";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_inventaire_liste_modif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox input_family;
        private System.Windows.Forms.ComboBox input_article;
        private System.Windows.Forms.TextBox input_quantity;
        private System.Windows.Forms.Button btn_inventaire_save;
        private System.Windows.Forms.Button btn_inventaire_add_article;
        private System.Windows.Forms.Label lbl_gestion_inventaire;
        private System.Windows.Forms.Button btn_inventaire_deconnect;
        private System.Windows.Forms.Button btn_synchro;
        private System.Windows.Forms.Label lbl_family;
        private System.Windows.Forms.Label lbl_article;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_inventaire_liste_modif;
        private System.Windows.Forms.DataGridView dtgv_inventaire_liste_modif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}