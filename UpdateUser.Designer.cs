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
			this.SuspendLayout();
			// 
			// lbl_titre
			// 
			this.lbl_titre.AutoSize = true;
			this.lbl_titre.Location = new System.Drawing.Point(347, 48);
			this.lbl_titre.Name = "lbl_titre";
			this.lbl_titre.Size = new System.Drawing.Size(89, 25);
			this.lbl_titre.TabIndex = 0;
			this.lbl_titre.Text = "Modifier";
			this.lbl_titre.Click += new System.EventHandler(this.lbl_titre_Click);
			// 
			// txtb_Login
			// 
			this.txtb_Login.Location = new System.Drawing.Point(204, 111);
			this.txtb_Login.Name = "txtb_Login";
			this.txtb_Login.Size = new System.Drawing.Size(200, 31);
			this.txtb_Login.TabIndex = 1;
			// 
			// txtb_password1
			// 
			this.txtb_password1.Location = new System.Drawing.Point(204, 172);
			this.txtb_password1.Name = "txtb_password1";
			this.txtb_password1.PasswordChar = '*';
			this.txtb_password1.Size = new System.Drawing.Size(200, 31);
			this.txtb_password1.TabIndex = 2;
			// 
			// tv_Login
			// 
			this.tv_Login.AutoSize = true;
			this.tv_Login.Location = new System.Drawing.Point(95, 114);
			this.tv_Login.Name = "tv_Login";
			this.tv_Login.Size = new System.Drawing.Size(65, 25);
			this.tv_Login.TabIndex = 3;
			this.tv_Login.Text = "Login";
			this.tv_Login.Click += new System.EventHandler(this.tv_Login_Click);
			// 
			// tv_password
			// 
			this.tv_password.AutoSize = true;
			this.tv_password.Location = new System.Drawing.Point(33, 178);
			this.tv_password.Name = "tv_password";
			this.tv_password.Size = new System.Drawing.Size(142, 25);
			this.tv_password.TabIndex = 4;
			this.tv_password.Text = "Mot de passe";
			// 
			// txtb_password2
			// 
			this.txtb_password2.Location = new System.Drawing.Point(450, 172);
			this.txtb_password2.Name = "txtb_password2";
			this.txtb_password2.PasswordChar = '*';
			this.txtb_password2.Size = new System.Drawing.Size(200, 31);
			this.txtb_password2.TabIndex = 5;
			// 
			// cb_admin
			// 
			this.cb_admin.AutoSize = true;
			this.cb_admin.Location = new System.Drawing.Point(204, 268);
			this.cb_admin.Name = "cb_admin";
			this.cb_admin.Size = new System.Drawing.Size(104, 29);
			this.cb_admin.TabIndex = 6;
			this.cb_admin.Text = "Admin";
			this.cb_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cb_admin.UseVisualStyleBackColor = true;
			// 
			// btn_Submit
			// 
			this.btn_Submit.Location = new System.Drawing.Point(320, 376);
			this.btn_Submit.Name = "btn_Submit";
			this.btn_Submit.Size = new System.Drawing.Size(147, 52);
			this.btn_Submit.TabIndex = 8;
			this.btn_Submit.Text = "Valider";
			this.btn_Submit.UseVisualStyleBackColor = true;
			this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
			// 
			// UpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Submit);
			this.Controls.Add(this.cb_admin);
			this.Controls.Add(this.txtb_password2);
			this.Controls.Add(this.tv_password);
			this.Controls.Add(this.tv_Login);
			this.Controls.Add(this.txtb_password1);
			this.Controls.Add(this.txtb_Login);
			this.Controls.Add(this.lbl_titre);
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
	}
}