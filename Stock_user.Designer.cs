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
            this.lbl_gestion_inventaire = new System.Windows.Forms.Label();
            this.btn_inventaire_deconnect = new System.Windows.Forms.Button();
            this.btn_synchro = new System.Windows.Forms.Button();
            this.lbl_family = new System.Windows.Forms.Label();
            this.lbl_article = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.input_quantity = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // input_family
            // 
            this.input_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_family.FormattingEnabled = true;
            this.input_family.Location = new System.Drawing.Point(128, 101);
            this.input_family.Name = "input_family";
            this.input_family.Size = new System.Drawing.Size(362, 39);
            this.input_family.TabIndex = 0;
            this.input_family.SelectedIndexChanged += new System.EventHandler(this.input_family_SelectedIndexChanged);
            // 
            // input_article
            // 
            this.input_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_article.FormattingEnabled = true;
            this.input_article.Location = new System.Drawing.Point(128, 169);
            this.input_article.Name = "input_article";
            this.input_article.Size = new System.Drawing.Size(362, 39);
            this.input_article.TabIndex = 1;
            this.input_article.SelectedIndexChanged += new System.EventHandler(this.input_article_SelectedIndexChanged);
            // 
            // lbl_gestion_inventaire
            // 
            this.lbl_gestion_inventaire.AutoSize = true;
            this.lbl_gestion_inventaire.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gestion_inventaire.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestion_inventaire.Location = new System.Drawing.Point(122, 37);
            this.lbl_gestion_inventaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gestion_inventaire.Name = "lbl_gestion_inventaire";
            this.lbl_gestion_inventaire.Size = new System.Drawing.Size(405, 34);
            this.lbl_gestion_inventaire.TabIndex = 8;
            this.lbl_gestion_inventaire.Text = "GESTION D\'INVENTAIRE";
            this.lbl_gestion_inventaire.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_inventaire_deconnect
            // 
            this.btn_inventaire_deconnect.Location = new System.Drawing.Point(506, 10);
            this.btn_inventaire_deconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inventaire_deconnect.Name = "btn_inventaire_deconnect";
            this.btn_inventaire_deconnect.Size = new System.Drawing.Size(100, 35);
            this.btn_inventaire_deconnect.TabIndex = 9;
            this.btn_inventaire_deconnect.Text = "Déconnexion";
            this.btn_inventaire_deconnect.UseVisualStyleBackColor = true;
            // 
            // btn_synchro
            // 
            this.btn_synchro.Location = new System.Drawing.Point(128, 306);
            this.btn_synchro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_synchro.Name = "btn_synchro";
            this.btn_synchro.Size = new System.Drawing.Size(362, 35);
            this.btn_synchro.TabIndex = 10;
            this.btn_synchro.Text = "Synchronisation";
            this.btn_synchro.UseVisualStyleBackColor = true;
            this.btn_synchro.Click += new System.EventHandler(this.btn_synchro_Click);
            // 
            // lbl_family
            // 
            this.lbl_family.AutoSize = true;
            this.lbl_family.BackColor = System.Drawing.Color.Transparent;
            this.lbl_family.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_family.Location = new System.Drawing.Point(33, 108);
            this.lbl_family.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_family.Name = "lbl_family";
            this.lbl_family.Size = new System.Drawing.Size(90, 25);
            this.lbl_family.TabIndex = 11;
            this.lbl_family.Text = "Famille";
            // 
            // lbl_article
            // 
            this.lbl_article.AutoSize = true;
            this.lbl_article.BackColor = System.Drawing.Color.Transparent;
            this.lbl_article.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_article.Location = new System.Drawing.Point(39, 176);
            this.lbl_article.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_article.Name = "lbl_article";
            this.lbl_article.Size = new System.Drawing.Size(85, 25);
            this.lbl_article.TabIndex = 12;
            this.lbl_article.Text = "Article";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quantity.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(23, 238);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(103, 25);
            this.lbl_quantity.TabIndex = 13;
            this.lbl_quantity.Text = "Quantité";
            // 
            // input_quantity
            // 
            this.input_quantity.BeepOnError = true;
            this.input_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_quantity.Location = new System.Drawing.Point(128, 231);
            this.input_quantity.Mask = "9999999999";
            this.input_quantity.Name = "input_quantity";
            this.input_quantity.Size = new System.Drawing.Size(362, 38);
            this.input_quantity.TabIndex = 16;
            this.input_quantity.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.input_quantity_MaskInputRejected);
            this.input_quantity.TextChanged += new System.EventHandler(this.input_quantity_TextChanged);
            // 
            // Stock_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 505);
            this.Controls.Add(this.input_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_article);
            this.Controls.Add(this.lbl_family);
            this.Controls.Add(this.btn_synchro);
            this.Controls.Add(this.btn_inventaire_deconnect);
            this.Controls.Add(this.lbl_gestion_inventaire);
            this.Controls.Add(this.input_article);
            this.Controls.Add(this.input_family);
            this.Name = "Stock_user";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox input_family;
        private System.Windows.Forms.ComboBox input_article;
        private System.Windows.Forms.Label lbl_gestion_inventaire;
        private System.Windows.Forms.Button btn_inventaire_deconnect;
        private System.Windows.Forms.Button btn_synchro;
        private System.Windows.Forms.Label lbl_family;
        private System.Windows.Forms.Label lbl_article;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.MaskedTextBox input_quantity;
    }
}