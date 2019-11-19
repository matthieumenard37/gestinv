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
            this.family = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.add_family = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.syncronize = new System.Windows.Forms.Button();
            this.delete_family = new System.Windows.Forms.Button();
            this.modify_family = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.delete_articles = new System.Windows.Forms.Button();
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
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(314, 393);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 45);
            this.save.TabIndex = 3;
            this.save.Text = "Enregistrer";
            this.save.UseVisualStyleBackColor = true;
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
            // delete_family
            // 
            this.delete_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_family.Location = new System.Drawing.Point(629, 106);
            this.delete_family.Name = "delete_family";
            this.delete_family.Size = new System.Drawing.Size(39, 39);
            this.delete_family.TabIndex = 7;
            this.delete_family.Text = "X";
            this.delete_family.UseVisualStyleBackColor = true;
            // 
            // modify_family
            // 
            this.modify_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_family.Location = new System.Drawing.Point(674, 106);
            this.modify_family.Name = "modify_family";
            this.modify_family.Size = new System.Drawing.Size(39, 39);
            this.modify_family.TabIndex = 8;
            this.modify_family.Text = "  /\r\nV";
            this.modify_family.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 151);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 207);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // delete_articles
            // 
            this.delete_articles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_articles.Location = new System.Drawing.Point(267, 364);
            this.delete_articles.Name = "delete_articles";
            this.delete_articles.Size = new System.Drawing.Size(254, 23);
            this.delete_articles.TabIndex = 10;
            this.delete_articles.Text = "Supprimer les articles sélectionnés";
            this.delete_articles.UseVisualStyleBackColor = true;
            // 
            // Stock_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_articles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.modify_family);
            this.Controls.Add(this.delete_family);
            this.Controls.Add(this.syncronize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.add_family);
            this.Controls.Add(this.save);
            this.Controls.Add(this.family);
            this.Name = "Stock_user";
            this.Text = "Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox family;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add_family;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button syncronize;
        private System.Windows.Forms.Button delete_family;
        private System.Windows.Forms.Button modify_family;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delete_articles;
    }
}