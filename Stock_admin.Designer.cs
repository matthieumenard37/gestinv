﻿namespace Gestinv
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
            this.add_family = new System.Windows.Forms.Button();
            this.modify_family = new System.Windows.Forms.Button();
            this.lbl_gestion_stocks = new System.Windows.Forms.Label();
            this.lbl_family = new System.Windows.Forms.Label();
            this.dtgv_articles = new System.Windows.Forms.DataGridView();
            this.lbl_articles = new System.Windows.Forms.Label();
            this.btn_add_article = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_families
            // 
            this.combobox_families.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_families.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_families.FormattingEnabled = true;
            this.combobox_families.Location = new System.Drawing.Point(227, 141);
            this.combobox_families.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combobox_families.Name = "combobox_families";
            this.combobox_families.Size = new System.Drawing.Size(664, 46);
            this.combobox_families.TabIndex = 0;
            this.combobox_families.SelectedIndexChanged += new System.EventHandler(this.combobox_families_SelectedIndexChanged);
            // 
            // add_family
            // 
            this.add_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_family.Location = new System.Drawing.Point(918, 141);
            this.add_family.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_family.Name = "add_family";
            this.add_family.Size = new System.Drawing.Size(52, 48);
            this.add_family.TabIndex = 4;
            this.add_family.Text = "+";
            this.add_family.UseVisualStyleBackColor = true;
            this.add_family.Click += new System.EventHandler(this.add_family_Click_1);
            // 
            // modify_family
            // 
            this.modify_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_family.Location = new System.Drawing.Point(988, 141);
            this.modify_family.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modify_family.Name = "modify_family";
            this.modify_family.Size = new System.Drawing.Size(52, 48);
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
            this.lbl_gestion_stocks.Location = new System.Drawing.Point(301, 42);
            this.lbl_gestion_stocks.Name = "lbl_gestion_stocks";
            this.lbl_gestion_stocks.Size = new System.Drawing.Size(455, 43);
            this.lbl_gestion_stocks.TabIndex = 11;
            this.lbl_gestion_stocks.Text = "GESTION DES STOCKS";
            // 
            // lbl_family
            // 
            this.lbl_family.AutoSize = true;
            this.lbl_family.Location = new System.Drawing.Point(136, 151);
            this.lbl_family.Name = "lbl_family";
            this.lbl_family.Size = new System.Drawing.Size(59, 17);
            this.lbl_family.TabIndex = 15;
            this.lbl_family.Text = "Familles";
            // 
            // dtgv_articles
            // 
            this.dtgv_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_articles.Location = new System.Drawing.Point(227, 229);
            this.dtgv_articles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_articles.Name = "dtgv_articles";
            this.dtgv_articles.ReadOnly = true;
            this.dtgv_articles.RowHeadersWidth = 51;
            this.dtgv_articles.RowTemplate.Height = 24;
            this.dtgv_articles.Size = new System.Drawing.Size(664, 370);
            this.dtgv_articles.TabIndex = 16;
            this.dtgv_articles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_articles_CellDoubleClick);
            // 
            // lbl_articles
            // 
            this.lbl_articles.AutoSize = true;
            this.lbl_articles.Location = new System.Drawing.Point(136, 229);
            this.lbl_articles.Name = "lbl_articles";
            this.lbl_articles.Size = new System.Drawing.Size(54, 17);
            this.lbl_articles.TabIndex = 17;
            this.lbl_articles.Text = "Articles";
            // 
            // btn_add_article
            // 
            this.btn_add_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_article.Location = new System.Drawing.Point(918, 229);
            this.btn_add_article.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(52, 48);
            this.btn_add_article.TabIndex = 18;
            this.btn_add_article.Text = "+";
            this.btn_add_article.UseVisualStyleBackColor = true;
            this.btn_add_article.Click += new System.EventHandler(this.btn_add_article_Click);
            // 
            // Stock_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 642);
            this.Controls.Add(this.btn_add_article);
            this.Controls.Add(this.lbl_articles);
            this.Controls.Add(this.dtgv_articles);
            this.Controls.Add(this.lbl_family);
            this.Controls.Add(this.lbl_gestion_stocks);
            this.Controls.Add(this.modify_family);
            this.Controls.Add(this.add_family);
            this.Controls.Add(this.combobox_families);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Stock_admin";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox combobox_families;
        private System.Windows.Forms.Button add_family;
        private System.Windows.Forms.Button modify_family;
        private System.Windows.Forms.Label lbl_gestion_stocks;
        private System.Windows.Forms.Label lbl_family;
        public System.Windows.Forms.DataGridView dtgv_articles;
        private System.Windows.Forms.Label lbl_articles;
        private System.Windows.Forms.Button btn_add_article;
    }
}