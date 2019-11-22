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
			this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Actif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_usersList)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgv_usersList
			// 
			this.dtgv_usersList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtgv_usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv_usersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Mail,
            this.Actif,
            this.Admin});
			this.dtgv_usersList.Location = new System.Drawing.Point(188, 91);
			this.dtgv_usersList.Name = "dtgv_usersList";
			this.dtgv_usersList.RowTemplate.Height = 24;
			this.dtgv_usersList.Size = new System.Drawing.Size(693, 282);
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
			// 
			// btn_deleteUser
			// 
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
			// Nom
			// 
			this.Nom.HeaderText = "Nom";
			this.Nom.Name = "Nom";
			this.Nom.Width = 200;
			// 
			// Mail
			// 
			this.Mail.HeaderText = "Mail";
			this.Mail.Name = "Mail";
			this.Mail.Width = 250;
			// 
			// Actif
			// 
			this.Actif.HeaderText = "Actif";
			this.Actif.Name = "Actif";
			this.Actif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Actif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Admin
			// 
			this.Admin.HeaderText = "Admin";
			this.Admin.Name = "Admin";
			this.Admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-2, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1098, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Utilisateurs";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UsersManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1082, 450);
			this.Controls.Add(this.btn_logout);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_updateUser);
			this.Controls.Add(this.btn_deleteUser);
			this.Controls.Add(this.btn_addUser);
			this.Controls.Add(this.dtgv_usersList);
			this.Name = "UsersManagement";
			this.Text = "UsersManagement";
			((System.ComponentModel.ISupportInitialize)(this.dtgv_usersList)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dtgv_usersList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Actif;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
		private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.Button btn_addUser;
		private System.Windows.Forms.Button btn_deleteUser;
		private System.Windows.Forms.Button btn_updateUser;
		private System.Windows.Forms.Label label1;
	}
}