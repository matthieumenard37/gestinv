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
            this.family = new System.Windows.Forms.ComboBox();
            this.article = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.add_article = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.syncronize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // family
            // 
            this.family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.family.FormattingEnabled = true;
            this.family.Location = new System.Drawing.Point(206, 106);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(362, 39);
            this.family.TabIndex = 0;
            // 
            // article
            // 
            this.article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article.FormattingEnabled = true;
            this.article.Location = new System.Drawing.Point(206, 167);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(362, 39);
            this.article.TabIndex = 1;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(334, 227);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 38);
            this.quantity.TabIndex = 2;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(304, 289);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 45);
            this.save.TabIndex = 3;
            this.save.Text = "Enregistrer";
            this.save.UseVisualStyleBackColor = true;
            // 
            // add_article
            // 
            this.add_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_article.Location = new System.Drawing.Point(586, 167);
            this.add_article.Name = "add_article";
            this.add_article.Size = new System.Drawing.Size(39, 39);
            this.add_article.TabIndex = 4;
            this.add_article.Text = "+";
            this.add_article.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(638, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(159, 39);
            this.logout.TabIndex = 5;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // syncronize
            // 
            this.syncronize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncronize.Location = new System.Drawing.Point(638, 47);
            this.syncronize.Name = "syncronize";
            this.syncronize.Size = new System.Drawing.Size(159, 39);
            this.syncronize.TabIndex = 6;
            this.syncronize.Text = "Syncronize";
            this.syncronize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.syncronize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.add_article);
            this.Controls.Add(this.save);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.article);
            this.Controls.Add(this.family);
            this.Name = "Form1";
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
    }
}