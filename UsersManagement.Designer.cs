﻿namespace Gestinv
{
    partial class UsersManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagement));
			this.dtgv_usersList = new System.Windows.Forms.DataGridView();
			this.btn_logout = new System.Windows.Forms.Button();
			this.btn_addUser = new System.Windows.Forms.Button();
			this.btn_deleteUser = new System.Windows.Forms.Button();
			this.btn_updateUser = new System.Windows.Forms.Button();
			this.lbl_titreUsersManagement = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Actif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_usersList)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgv_usersList
			// 
			this.dtgv_usersList.AllowUserToAddRows = false;
			this.dtgv_usersList.AllowUserToDeleteRows = false;
			this.dtgv_usersList.AllowUserToOrderColumns = true;
			this.dtgv_usersList.AllowUserToResizeColumns = false;
			this.dtgv_usersList.AllowUserToResizeRows = false;
			this.dtgv_usersList.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtgv_usersList.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dtgv_usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv_usersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Id,
            this.Password,
            this.Actif,
            this.Admin});
			this.dtgv_usersList.Location = new System.Drawing.Point(15, 100);
			this.dtgv_usersList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtgv_usersList.Name = "dtgv_usersList";
			this.dtgv_usersList.ReadOnly = true;
			this.dtgv_usersList.RowHeadersWidth = 82;
			this.dtgv_usersList.RowTemplate.Height = 24;
			this.dtgv_usersList.Size = new System.Drawing.Size(595, 229);
			this.dtgv_usersList.TabIndex = 0;
			this.dtgv_usersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_usersList_CellContentClick);
			this.dtgv_usersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_usersList_CellDoubleClick);
			// 
			// btn_logout
			// 
			this.btn_logout.BackColor = System.Drawing.Color.DimGray;
			this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
			this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
			this.btn_logout.Location = new System.Drawing.Point(754, 10);
			this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(48, 48);
			this.btn_logout.TabIndex = 5;
			this.btn_logout.UseVisualStyleBackColor = false;
			// 
			// btn_addUser
			// 
			this.btn_addUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_addUser.BackColor = System.Drawing.Color.DimGray;
			this.btn_addUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addUser.BackgroundImage")));
			this.btn_addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_addUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_addUser.ForeColor = System.Drawing.Color.Transparent;
			this.btn_addUser.Location = new System.Drawing.Point(284, 382);
			this.btn_addUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_addUser.Name = "btn_addUser";
			this.btn_addUser.Size = new System.Drawing.Size(48, 48);
			this.btn_addUser.TabIndex = 3;
			this.btn_addUser.UseVisualStyleBackColor = false;
			this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
			// 
			// btn_deleteUser
			// 
			this.btn_deleteUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_deleteUser.BackColor = System.Drawing.Color.DimGray;
			this.btn_deleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deleteUser.BackgroundImage")));
			this.btn_deleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_deleteUser.ForeColor = System.Drawing.Color.Transparent;
			this.btn_deleteUser.Location = new System.Drawing.Point(388, 382);
			this.btn_deleteUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_deleteUser.Name = "btn_deleteUser";
			this.btn_deleteUser.Size = new System.Drawing.Size(48, 48);
			this.btn_deleteUser.TabIndex = 4;
			this.btn_deleteUser.UseVisualStyleBackColor = false;
			this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
			// 
			// btn_updateUser
			// 
			this.btn_updateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_updateUser.BackColor = System.Drawing.Color.DimGray;
			this.btn_updateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_updateUser.BackgroundImage")));
			this.btn_updateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_updateUser.ForeColor = System.Drawing.Color.Transparent;
			this.btn_updateUser.Location = new System.Drawing.Point(494, 382);
			this.btn_updateUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btn_updateUser.Name = "btn_updateUser";
			this.btn_updateUser.Size = new System.Drawing.Size(48, 48);
			this.btn_updateUser.TabIndex = 5;
			this.btn_updateUser.UseVisualStyleBackColor = false;
			this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
			// 
			// lbl_titreUsersManagement
			// 
			this.lbl_titreUsersManagement.BackColor = System.Drawing.Color.Transparent;
			this.lbl_titreUsersManagement.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titreUsersManagement.Location = new System.Drawing.Point(-2, 14);
			this.lbl_titreUsersManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_titreUsersManagement.Name = "lbl_titreUsersManagement";
			this.lbl_titreUsersManagement.Size = new System.Drawing.Size(820, 35);
			this.lbl_titreUsersManagement.TabIndex = 0;
			this.lbl_titreUsersManagement.Text = "GESTION DES UTILISATEURS";
			this.lbl_titreUsersManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_titreUsersManagement.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(637, 106);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Filtrer";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Nom
			// 
			this.Nom.DataPropertyName = "Login";
			this.Nom.HeaderText = "Login";
			this.Nom.MinimumWidth = 10;
			this.Nom.Name = "Nom";
			this.Nom.ReadOnly = true;
			this.Nom.Width = 250;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.MinimumWidth = 10;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			this.Id.Width = 10;
			// 
			// Password
			// 
			this.Password.DataPropertyName = "password";
			this.Password.HeaderText = "Password";
			this.Password.MinimumWidth = 10;
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.Visible = false;
			this.Password.Width = 200;
			// 
			// Actif
			// 
			this.Actif.DataPropertyName = "state";
			this.Actif.FalseValue = "false";
			this.Actif.HeaderText = "Actif";
			this.Actif.MinimumWidth = 10;
			this.Actif.Name = "Actif";
			this.Actif.ReadOnly = true;
			this.Actif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Actif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Actif.TrueValue = "true";
			this.Actif.Visible = false;
			this.Actif.Width = 55;
			// 
			// Admin
			// 
			this.Admin.DataPropertyName = "admin";
			this.Admin.FalseValue = "false";
			this.Admin.HeaderText = "Admin";
			this.Admin.MinimumWidth = 10;
			this.Admin.Name = "Admin";
			this.Admin.ReadOnly = true;
			this.Admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Admin.TrueValue = "true";
			this.Admin.Width = 55;
			// 
			// UsersManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(834, 437);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_logout);
			this.Controls.Add(this.lbl_titreUsersManagement);
			this.Controls.Add(this.btn_updateUser);
			this.Controls.Add(this.btn_deleteUser);
			this.Controls.Add(this.btn_addUser);
			this.Controls.Add(this.dtgv_usersList);
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "UsersManagement";
			this.Text = "UsersManagement";
			this.Load += new System.EventHandler(this.UsersManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgv_usersList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		public System.Windows.Forms.DataGridView dtgv_usersList;
		private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.Button btn_addUser;
		private System.Windows.Forms.Button btn_deleteUser;
		private System.Windows.Forms.Button btn_updateUser;
		private System.Windows.Forms.Label lbl_titreUsersManagement;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Actif;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
	}
}