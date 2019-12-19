namespace Gestinv
{
    partial class UpdateArticle
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
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_family = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.txtb_location = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(108, 122);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(120, 20);
            this.nud_quantity.TabIndex = 24;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(54, 122);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(47, 13);
            this.lbl_quantity.TabIndex = 23;
            this.lbl_quantity.Text = "Quantité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Famille";
            // 
            // comboBox_family
            // 
            this.comboBox_family.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_family.FormattingEnabled = true;
            this.comboBox_family.Location = new System.Drawing.Point(108, 90);
            this.comboBox_family.Name = "comboBox_family";
            this.comboBox_family.Size = new System.Drawing.Size(231, 21);
            this.comboBox_family.TabIndex = 21;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.Location = new System.Drawing.Point(200, 192);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(152, 43);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "SUPPRIMER ARTICLE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(11, 192);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(152, 43);
            this.btn_Submit.TabIndex = 19;
            this.btn_Submit.Text = "ENREGISTRER";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(21, 153);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(71, 13);
            this.lbl_location.TabIndex = 18;
            this.lbl_location.Text = "Emplacement";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(54, 56);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(29, 13);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Nom";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(108, 55);
            this.txtb_name.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(231, 20);
            this.txtb_name.TabIndex = 15;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(105, 23);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(44, 13);
            this.lbl_titre.TabIndex = 14;
            this.lbl_titre.Text = "Modifier";
            // 
            // txtb_location
            // 
            this.txtb_location.Location = new System.Drawing.Point(108, 150);
            this.txtb_location.Mask = ">A0<A";
            this.txtb_location.Name = "txtb_location";
            this.txtb_location.Size = new System.Drawing.Size(231, 20);
            this.txtb_location.TabIndex = 25;
            // 
            // UpdateArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 246);
            this.Controls.Add(this.txtb_location);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_family);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.lbl_titre);
            this.Name = "UpdateArticle";
            this.Text = "UpdateArticle";
            this.Load += new System.EventHandler(this.UpdateArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_family;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.MaskedTextBox txtb_location;
    }
}