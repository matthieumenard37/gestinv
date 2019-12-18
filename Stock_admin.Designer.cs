namespace Gestinv
{
    partial class Stock_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_admin));
            this.combobox_families = new System.Windows.Forms.ComboBox();
            this.btn_gestion_stocks_save = new System.Windows.Forms.Button();
            this.add_family = new System.Windows.Forms.Button();
            this.modify_family = new System.Windows.Forms.Button();
            this.lbl_gestion_stocks = new System.Windows.Forms.Label();
            this.btn_gestion_stocks_delete = new System.Windows.Forms.Button();
            this.btn_gestion_stocks_deconnect = new System.Windows.Forms.Button();
            this.btn_gestion_stocks_back = new System.Windows.Forms.Button();
            this.lbl_family = new System.Windows.Forms.Label();
            this.dtgv_articles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_families
            // 
            this.combobox_families.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_families.FormattingEnabled = true;
            this.combobox_families.Location = new System.Drawing.Point(206, 106);
            this.combobox_families.Name = "combobox_families";
            this.combobox_families.Size = new System.Drawing.Size(362, 39);
            this.combobox_families.TabIndex = 0;
            this.combobox_families.SelectedIndexChanged += new System.EventHandler(this.combobox_families_SelectedIndexChanged);
            // 
            // btn_gestion_stocks_save
            // 
            this.btn_gestion_stocks_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestion_stocks_save.Location = new System.Drawing.Point(196, 405);
            this.btn_gestion_stocks_save.Name = "btn_gestion_stocks_save";
            this.btn_gestion_stocks_save.Size = new System.Drawing.Size(158, 45);
            this.btn_gestion_stocks_save.TabIndex = 3;
            this.btn_gestion_stocks_save.Text = "Enregistrer";
            this.btn_gestion_stocks_save.UseVisualStyleBackColor = true;
            // 
            // add_family
            // 
            this.add_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_family.Location = new System.Drawing.Point(584, 106);
            this.add_family.Name = "add_family";
            this.add_family.Size = new System.Drawing.Size(39, 39);
            this.add_family.TabIndex = 4;
            this.add_family.Text = "+";
            this.add_family.UseVisualStyleBackColor = true;
            this.add_family.Click += new System.EventHandler(this.add_family_Click_1);
            // 
            // modify_family
            // 
            this.modify_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_family.Location = new System.Drawing.Point(629, 106);
            this.modify_family.Name = "modify_family";
            this.modify_family.Size = new System.Drawing.Size(39, 39);
            this.modify_family.TabIndex = 8;
            this.modify_family.Text = "  /\r\nV";
            this.modify_family.UseVisualStyleBackColor = true;
            this.modify_family.Click += new System.EventHandler(this.modify_family_Click);
            // 
            // lbl_gestion_stocks
            // 
            this.lbl_gestion_stocks.AutoSize = true;
            this.lbl_gestion_stocks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gestion_stocks.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestion_stocks.Location = new System.Drawing.Point(226, 34);
            this.lbl_gestion_stocks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gestion_stocks.Name = "lbl_gestion_stocks";
            this.lbl_gestion_stocks.Size = new System.Drawing.Size(371, 34);
            this.lbl_gestion_stocks.TabIndex = 11;
            this.lbl_gestion_stocks.Text = "GESTION DES STOCKS";
            // 
            // btn_gestion_stocks_delete
            // 
            this.btn_gestion_stocks_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestion_stocks_delete.Location = new System.Drawing.Point(447, 405);
            this.btn_gestion_stocks_delete.Name = "btn_gestion_stocks_delete";
            this.btn_gestion_stocks_delete.Size = new System.Drawing.Size(158, 45);
            this.btn_gestion_stocks_delete.TabIndex = 12;
            this.btn_gestion_stocks_delete.Text = "Supprimer";
            this.btn_gestion_stocks_delete.UseVisualStyleBackColor = true;
            // 
            // btn_gestion_stocks_deconnect
            // 
            this.btn_gestion_stocks_deconnect.Location = new System.Drawing.Point(691, 10);
            this.btn_gestion_stocks_deconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gestion_stocks_deconnect.Name = "btn_gestion_stocks_deconnect";
            this.btn_gestion_stocks_deconnect.Size = new System.Drawing.Size(100, 35);
            this.btn_gestion_stocks_deconnect.TabIndex = 13;
            this.btn_gestion_stocks_deconnect.Text = "Déconnexion";
            this.btn_gestion_stocks_deconnect.UseVisualStyleBackColor = true;
            // 
            // btn_gestion_stocks_back
            // 
            this.btn_gestion_stocks_back.Location = new System.Drawing.Point(9, 10);
            this.btn_gestion_stocks_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gestion_stocks_back.Name = "btn_gestion_stocks_back";
            this.btn_gestion_stocks_back.Size = new System.Drawing.Size(100, 35);
            this.btn_gestion_stocks_back.TabIndex = 14;
            this.btn_gestion_stocks_back.Text = "Retour Accueil";
            this.btn_gestion_stocks_back.UseVisualStyleBackColor = true;
            // 
            // lbl_family
            // 
            this.lbl_family.AutoSize = true;
            this.lbl_family.Location = new System.Drawing.Point(102, 119);
            this.lbl_family.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_family.Name = "lbl_family";
            this.lbl_family.Size = new System.Drawing.Size(39, 13);
            this.lbl_family.TabIndex = 15;
            this.lbl_family.Text = "Famille";
            // 
            // dtgv_articles
            // 
            this.dtgv_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_articles.Location = new System.Drawing.Point(206, 186);
            this.dtgv_articles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_articles.Name = "dtgv_articles";
            this.dtgv_articles.RowHeadersWidth = 51;
            this.dtgv_articles.RowTemplate.Height = 24;
            this.dtgv_articles.Size = new System.Drawing.Size(416, 122);
            this.dtgv_articles.TabIndex = 16;
            this.dtgv_articles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_articles_CellDoubleClick);
            // 
            // Stock_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.dtgv_articles);
            this.Controls.Add(this.lbl_family);
            this.Controls.Add(this.btn_gestion_stocks_back);
            this.Controls.Add(this.btn_gestion_stocks_deconnect);
            this.Controls.Add(this.btn_gestion_stocks_delete);
            this.Controls.Add(this.lbl_gestion_stocks);
            this.Controls.Add(this.modify_family);
            this.Controls.Add(this.add_family);
            this.Controls.Add(this.btn_gestion_stocks_save);
            this.Controls.Add(this.combobox_families);
            this.Name = "Stock_admin";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_families;
        private System.Windows.Forms.Button btn_gestion_stocks_save;
        private System.Windows.Forms.Button add_family;
        private System.Windows.Forms.Button modify_family;
        private System.Windows.Forms.Label lbl_gestion_stocks;
        private System.Windows.Forms.Button btn_gestion_stocks_delete;
        private System.Windows.Forms.Button btn_gestion_stocks_deconnect;
        private System.Windows.Forms.Button btn_gestion_stocks_back;
        private System.Windows.Forms.Label lbl_family;
        private System.Windows.Forms.DataGridView dtgv_articles;
    }
}