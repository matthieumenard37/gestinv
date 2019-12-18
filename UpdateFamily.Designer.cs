namespace Gestinv
{
    partial class UpdateFamily
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.Location = new System.Drawing.Point(435, 219);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(202, 52);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "SUPPRIMER FAMILLE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(193, 219);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(202, 52);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "ENREGISTRER";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(225, 145);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(37, 17);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Nom";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(302, 140);
            this.txtb_name.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(335, 22);
            this.txtb_name.TabIndex = 11;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(358, 85);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(58, 17);
            this.lbl_titre.TabIndex = 10;
            this.lbl_titre.Text = "Modifier";
            // 
            // UpdateFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.lbl_titre);
            this.Name = "UpdateFamily";
            this.Text = "UpdateFamily";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label lbl_titre;
    }
}