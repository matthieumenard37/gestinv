namespace Gestinv
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
			this.cb_filter = new System.Windows.Forms.CheckBox();
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
			this.dtgv_usersList.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtgv_usersList.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dtgv_usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv_usersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Id,
            this.Password,
            this.Actif,
            this.Admin});
			this.dtgv_usersList.Location = new System.Drawing.Point(188, 91);
			this.dtgv_usersList.Name = "dtgv_usersList";
			this.dtgv_usersList.RowTemplate.Height = 24;
			this.dtgv_usersList.Size = new System.Drawing.Size(595, 282);
			this.dtgv_usersList.TabIndex = 0;
			// 
			// btn_logout
			// 
			this.btn_logout.BackColor = System.Drawing.Color.DimGray;
			this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
			this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
			this.btn_logout.Location = new System.Drawing.Point(1006, 12);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(64, 59);
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
			this.btn_addUser.Location = new System.Drawing.Point(364, 382);
			this.btn_addUser.Name = "btn_addUser";
			this.btn_addUser.Size = new System.Drawing.Size(64, 59);
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
			this.btn_deleteUser.Location = new System.Drawing.Point(503, 382);
			this.btn_deleteUser.Name = "btn_deleteUser";
			this.btn_deleteUser.Size = new System.Drawing.Size(64, 59);
			this.btn_deleteUser.TabIndex = 4;
			this.btn_deleteUser.UseVisualStyleBackColor = false;
			// 
			// btn_updateUser
			// 
			this.btn_updateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_updateUser.BackColor = System.Drawing.Color.DimGray;
			this.btn_updateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_updateUser.BackgroundImage")));
			this.btn_updateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_updateUser.ForeColor = System.Drawing.Color.Transparent;
			this.btn_updateUser.Location = new System.Drawing.Point(643, 382);
			this.btn_updateUser.Name = "btn_updateUser";
			this.btn_updateUser.Size = new System.Drawing.Size(64, 59);
			this.btn_updateUser.TabIndex = 5;
			this.btn_updateUser.UseVisualStyleBackColor = false;
			// 
			// lbl_titreUsersManagement
			// 
			this.lbl_titreUsersManagement.BackColor = System.Drawing.Color.Transparent;
			this.lbl_titreUsersManagement.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titreUsersManagement.Location = new System.Drawing.Point(-2, 17);
			this.lbl_titreUsersManagement.Name = "lbl_titreUsersManagement";
			this.lbl_titreUsersManagement.Size = new System.Drawing.Size(1094, 43);
			this.lbl_titreUsersManagement.TabIndex = 0;
			this.lbl_titreUsersManagement.Text = "GESTION DES UTILISATEURS";
			this.lbl_titreUsersManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_titreUsersManagement.Click += new System.EventHandler(this.label1_Click);
			// 
			// cb_filter
			// 
			this.cb_filter.AutoSize = true;
			this.cb_filter.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_filter.Location = new System.Drawing.Point(789, 166);
			this.cb_filter.Name = "cb_filter";
			this.cb_filter.Size = new System.Drawing.Size(257, 24);
			this.cb_filter.TabIndex = 6;
			this.cb_filter.Text = "Afficher les utilisateur inactifs";
			this.cb_filter.UseVisualStyleBackColor = true;
			this.cb_filter.CheckedChanged += new System.EventHandler(this.cb_filter_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(789, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 30);
			this.label2.TabIndex = 7;
			this.label2.Text = "Filtrer";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Nom
			// 
			this.Nom.DataPropertyName = "Login";
			this.Nom.HeaderText = "Nom";
			this.Nom.Name = "Nom";
			this.Nom.Width = 200;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// Password
			// 
			this.Password.DataPropertyName = "password";
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			this.Password.Visible = false;
			// 
			// Actif
			// 
			this.Actif.DataPropertyName = "state";
			this.Actif.FalseValue = "false";
			this.Actif.HeaderText = "Actif";
			this.Actif.Name = "Actif";
			this.Actif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Actif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Actif.TrueValue = "true";
			// 
			// Admin
			// 
			this.Admin.DataPropertyName = "admin";
			this.Admin.FalseValue = "false";
			this.Admin.HeaderText = "Admin";
			this.Admin.Name = "Admin";
			this.Admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Admin.TrueValue = "true";
			// 
			// UsersManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1082, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cb_filter);
			this.Controls.Add(this.btn_logout);
			this.Controls.Add(this.lbl_titreUsersManagement);
			this.Controls.Add(this.btn_updateUser);
			this.Controls.Add(this.btn_deleteUser);
			this.Controls.Add(this.btn_addUser);
			this.Controls.Add(this.dtgv_usersList);
			this.Name = "UsersManagement";
			this.Text = "UsersManagement";
			this.Load += new System.EventHandler(this.UsersManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgv_usersList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dtgv_usersList;
		private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.Button btn_addUser;
		private System.Windows.Forms.Button btn_deleteUser;
		private System.Windows.Forms.Button btn_updateUser;
		private System.Windows.Forms.Label lbl_titreUsersManagement;
		private System.Windows.Forms.CheckBox cb_filter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Actif;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
	}
}