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
            this.family = new System.Windows.Forms.ComboBox();
            this.article = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.add_article = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.syncronize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // family
            // 
            this.family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.family.FormattingEnabled = true;
            this.family.Location = new System.Drawing.Point(119, 130);
            this.family.Margin = new System.Windows.Forms.Padding(4);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(481, 46);
            this.family.TabIndex = 0;
            // 
            // article
            // 
            this.article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article.FormattingEnabled = true;
            this.article.Location = new System.Drawing.Point(119, 208);
            this.article.Margin = new System.Windows.Forms.Padding(4);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(481, 46);
            this.article.TabIndex = 1;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(289, 283);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(132, 45);
            this.quantity.TabIndex = 2;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(252, 353);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(211, 55);
            this.save.TabIndex = 3;
            this.save.Text = "Enregistrer";
            this.save.UseVisualStyleBackColor = true;
            // 
            // add_article
            // 
            this.add_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_article.Location = new System.Drawing.Point(621, 208);
            this.add_article.Margin = new System.Windows.Forms.Padding(4);
            this.add_article.Name = "add_article";
            this.add_article.Size = new System.Drawing.Size(52, 48);
            this.add_article.TabIndex = 4;
            this.add_article.Text = "+";
            this.add_article.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(621, 13);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(212, 48);
            this.logout.TabIndex = 5;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // syncronize
            // 
            this.syncronize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncronize.Location = new System.Drawing.Point(621, 80);
            this.syncronize.Margin = new System.Windows.Forms.Padding(4);
            this.syncronize.Name = "syncronize";
            this.syncronize.Size = new System.Drawing.Size(212, 48);
            this.syncronize.TabIndex = 6;
            this.syncronize.Text = "Syncronize";
            this.syncronize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gestion d\'inventaire";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Stock_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.syncronize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.add_article);
            this.Controls.Add(this.save);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.article);
            this.Controls.Add(this.family);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock_user";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox family;
        private System.Windows.Forms.ComboBox article;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add_article;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button syncronize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}