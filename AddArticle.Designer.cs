namespace Gestinv
{
    partial class AddArticle
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
            this.btn_add_article = new System.Windows.Forms.Button();
            this.lbl_article_name = new System.Windows.Forms.Label();
            this.txtBox_article_name = new System.Windows.Forms.TextBox();
            this.lbl_add_article = new System.Windows.Forms.Label();
            this.lbl_family_name = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_location_code = new System.Windows.Forms.Label();
            this.maskedTextB_location_code = new System.Windows.Forms.MaskedTextBox();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox_family_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_article
            // 
            this.btn_add_article.Location = new System.Drawing.Point(291, 303);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(87, 22);
            this.btn_add_article.TabIndex = 7;
            this.btn_add_article.Text = "Créer";
            this.btn_add_article.UseVisualStyleBackColor = true;
            this.btn_add_article.Click += new System.EventHandler(this.btn_add_article_Click);
            // 
            // lbl_article_name
            // 
            this.lbl_article_name.AutoSize = true;
            this.lbl_article_name.Location = new System.Drawing.Point(137, 88);
            this.lbl_article_name.Name = "lbl_article_name";
            this.lbl_article_name.Size = new System.Drawing.Size(105, 17);
            this.lbl_article_name.TabIndex = 6;
            this.lbl_article_name.Text = "Nom de l\'article";
            // 
            // txtBox_article_name
            // 
            this.txtBox_article_name.Location = new System.Drawing.Point(291, 88);
            this.txtBox_article_name.Name = "txtBox_article_name";
            this.txtBox_article_name.Size = new System.Drawing.Size(168, 22);
            this.txtBox_article_name.TabIndex = 5;
            // 
            // lbl_add_article
            // 
            this.lbl_add_article.AutoSize = true;
            this.lbl_add_article.Location = new System.Drawing.Point(300, 42);
            this.lbl_add_article.Name = "lbl_add_article";
            this.lbl_add_article.Size = new System.Drawing.Size(115, 17);
            this.lbl_add_article.TabIndex = 4;
            this.lbl_add_article.Text = "Ajouter un article";
            // 
            // lbl_family_name
            // 
            this.lbl_family_name.AutoSize = true;
            this.lbl_family_name.Location = new System.Drawing.Point(137, 144);
            this.lbl_family_name.Name = "lbl_family_name";
            this.lbl_family_name.Size = new System.Drawing.Size(116, 17);
            this.lbl_family_name.TabIndex = 8;
            this.lbl_family_name.Text = "Nom de la famille";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(137, 199);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(62, 17);
            this.lbl_quantity.TabIndex = 9;
            this.lbl_quantity.Text = "Quantité";
            this.lbl_quantity.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_location_code
            // 
            this.lbl_location_code.AutoSize = true;
            this.lbl_location_code.Location = new System.Drawing.Point(137, 252);
            this.lbl_location_code.Name = "lbl_location_code";
            this.lbl_location_code.Size = new System.Drawing.Size(93, 17);
            this.lbl_location_code.TabIndex = 10;
            this.lbl_location_code.Text = "Emplacement";
            // 
            // maskedTextB_location_code
            // 
            this.maskedTextB_location_code.Location = new System.Drawing.Point(291, 252);
            this.maskedTextB_location_code.Mask = ">A0<A";
            this.maskedTextB_location_code.Name = "maskedTextB_location_code";
            this.maskedTextB_location_code.Size = new System.Drawing.Size(28, 22);
            this.maskedTextB_location_code.TabIndex = 11;
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(291, 199);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(87, 22);
            this.nud_quantity.TabIndex = 12;
            // 
            // comboBox_family_name
            // 
            this.comboBox_family_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_family_name.FormattingEnabled = true;
            this.comboBox_family_name.Location = new System.Drawing.Point(291, 144);
            this.comboBox_family_name.Name = "comboBox_family_name";
            this.comboBox_family_name.Size = new System.Drawing.Size(165, 24);
            this.comboBox_family_name.TabIndex = 13;
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_family_name);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.maskedTextB_location_code);
            this.Controls.Add(this.lbl_location_code);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_family_name);
            this.Controls.Add(this.btn_add_article);
            this.Controls.Add(this.lbl_article_name);
            this.Controls.Add(this.txtBox_article_name);
            this.Controls.Add(this.lbl_add_article);
            this.Name = "AddArticle";
            this.Text = "AddArticle";
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_article;
        private System.Windows.Forms.Label lbl_article_name;
        private System.Windows.Forms.TextBox txtBox_article_name;
        private System.Windows.Forms.Label lbl_add_article;
        private System.Windows.Forms.Label lbl_family_name;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_location_code;
        private System.Windows.Forms.MaskedTextBox maskedTextB_location_code;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.ComboBox comboBox_family_name;
    }
}