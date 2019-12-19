namespace Gestinv
{
	partial class UpdateUser
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.txtb_Login = new System.Windows.Forms.TextBox();
            this.txtb_password1 = new System.Windows.Forms.MaskedTextBox();
            this.tv_Login = new System.Windows.Forms.Label();
            this.tv_password = new System.Windows.Forms.Label();
            this.txtb_password2 = new System.Windows.Forms.MaskedTextBox();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(113, 20);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(44, 13);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Modifier";
            this.lbl_titre.Click += new System.EventHandler(this.lbl_titre_Click);
            // 
            // txtb_Login
            // 
            this.txtb_Login.Location = new System.Drawing.Point(102, 58);
            this.txtb_Login.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_Login.Name = "txtb_Login";
            this.txtb_Login.Size = new System.Drawing.Size(275, 20);
            this.txtb_Login.TabIndex = 1;
            // 
            // txtb_password1
            // 
            this.txtb_password1.Location = new System.Drawing.Point(102, 89);
            this.txtb_password1.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_password1.Name = "txtb_password1";
            this.txtb_password1.PasswordChar = '*';
            this.txtb_password1.Size = new System.Drawing.Size(132, 20);
            this.txtb_password1.TabIndex = 2;
            // 
            // tv_Login
            // 
            this.tv_Login.AutoSize = true;
            this.tv_Login.Location = new System.Drawing.Point(48, 59);
            this.tv_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tv_Login.Name = "tv_Login";
            this.tv_Login.Size = new System.Drawing.Size(33, 13);
            this.tv_Login.TabIndex = 3;
            this.tv_Login.Text = "Login";
            this.tv_Login.Click += new System.EventHandler(this.tv_Login_Click);
            // 
            // tv_password
            // 
            this.tv_password.AutoSize = true;
            this.tv_password.Location = new System.Drawing.Point(16, 93);
            this.tv_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tv_password.Name = "tv_password";
            this.tv_password.Size = new System.Drawing.Size(71, 13);
            this.tv_password.TabIndex = 4;
            this.tv_password.Text = "Mot de passe";
            // 
            // txtb_password2
            // 
            this.txtb_password2.Location = new System.Drawing.Point(238, 89);
            this.txtb_password2.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_password2.Name = "txtb_password2";
            this.txtb_password2.PasswordChar = '*';
            this.txtb_password2.Size = new System.Drawing.Size(139, 20);
            this.txtb_password2.TabIndex = 5;
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(102, 122);
            this.cb_admin.Margin = new System.Windows.Forms.Padding(2);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(55, 17);
            this.cb_admin.TabIndex = 6;
            this.cb_admin.Text = "Admin";
            this.cb_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(19, 155);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(152, 43);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "ENREGISTRER";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.Location = new System.Drawing.Point(225, 155);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(152, 43);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "SUPPRIMER UTILISATEUR";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 211);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cb_admin);
            this.Controls.Add(this.txtb_password2);
            this.Controls.Add(this.tv_password);
            this.Controls.Add(this.tv_Login);
            this.Controls.Add(this.txtb_password1);
            this.Controls.Add(this.txtb_Login);
            this.Controls.Add(this.lbl_titre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_titre;
		private System.Windows.Forms.TextBox txtb_Login;
		private System.Windows.Forms.MaskedTextBox txtb_password1;
		private System.Windows.Forms.Label tv_Login;
		private System.Windows.Forms.Label tv_password;
		private System.Windows.Forms.MaskedTextBox txtb_password2;
		private System.Windows.Forms.CheckBox cb_admin;
		private System.Windows.Forms.Button btn_Submit;
		private System.Windows.Forms.Button btn_delete;
	}
}