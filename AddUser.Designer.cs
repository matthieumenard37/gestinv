namespace Gestinv
{
	partial class AddUser
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBox_Password_1 = new System.Windows.Forms.TextBox();
			this.txtBox_Name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_AddUser = new System.Windows.Forms.Button();
			this.cb_admin = new System.Windows.Forms.CheckBox();
			this.txtBox_Password_2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(617, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ajouter un utilisateur";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtBox_Password_1
			// 
			this.txtBox_Password_1.Location = new System.Drawing.Point(90, 372);
			this.txtBox_Password_1.Name = "txtBox_Password_1";
			this.txtBox_Password_1.Size = new System.Drawing.Size(500, 31);
			this.txtBox_Password_1.TabIndex = 2;
			// 
			// txtBox_Name
			// 
			this.txtBox_Name.Location = new System.Drawing.Point(90, 234);
			this.txtBox_Name.Name = "txtBox_Name";
			this.txtBox_Name.Size = new System.Drawing.Size(500, 31);
			this.txtBox_Name.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(90, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(90, 323);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mot de passe";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// btn_AddUser
			// 
			this.btn_AddUser.Location = new System.Drawing.Point(253, 636);
			this.btn_AddUser.Name = "btn_AddUser";
			this.btn_AddUser.Size = new System.Drawing.Size(137, 71);
			this.btn_AddUser.TabIndex = 6;
			this.btn_AddUser.Text = "Créer";
			this.btn_AddUser.UseVisualStyleBackColor = true;
			this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
			// 
			// cb_admin
			// 
			this.cb_admin.AutoSize = true;
			this.cb_admin.Location = new System.Drawing.Point(90, 560);
			this.cb_admin.Name = "cb_admin";
			this.cb_admin.Size = new System.Drawing.Size(104, 29);
			this.cb_admin.TabIndex = 7;
			this.cb_admin.Text = "Admin";
			this.cb_admin.UseVisualStyleBackColor = true;
			// 
			// txtBox_Password_2
			// 
			this.txtBox_Password_2.Location = new System.Drawing.Point(90, 478);
			this.txtBox_Password_2.Name = "txtBox_Password_2";
			this.txtBox_Password_2.Size = new System.Drawing.Size(500, 31);
			this.txtBox_Password_2.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(90, 438);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(239, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Vérifier le Mot de passe";
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 764);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBox_Password_2);
			this.Controls.Add(this.cb_admin);
			this.Controls.Add(this.btn_AddUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBox_Name);
			this.Controls.Add(this.txtBox_Password_1);
			this.Controls.Add(this.label1);
			this.Name = "AddUser";
			this.Text = "AddUser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBox_Password_1;
		private System.Windows.Forms.TextBox txtBox_Name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_AddUser;
		private System.Windows.Forms.CheckBox cb_admin;
		private System.Windows.Forms.TextBox txtBox_Password_2;
		private System.Windows.Forms.Label label4;
	}
}