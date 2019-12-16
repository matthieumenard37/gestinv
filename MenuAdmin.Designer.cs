namespace Gestinv
{
	partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.btn_voir_stocks = new System.Windows.Forms.Button();
            this.btn_consulter_journal_log = new System.Windows.Forms.Button();
            this.btn_gerer_utilsateurs = new System.Windows.Forms.Button();
            this.lbl_menu_admin = new System.Windows.Forms.Label();
            this.btn_menu_admin_deconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_voir_stocks
            // 
            this.btn_voir_stocks.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voir_stocks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voir_stocks.Image = ((System.Drawing.Image)(resources.GetObject("btn_voir_stocks.Image")));
            this.btn_voir_stocks.Location = new System.Drawing.Point(10, 129);
            this.btn_voir_stocks.Name = "btn_voir_stocks";
            this.btn_voir_stocks.Size = new System.Drawing.Size(783, 133);
            this.btn_voir_stocks.TabIndex = 1;
            this.btn_voir_stocks.Text = "Voir les Stocks";
            this.btn_voir_stocks.UseVisualStyleBackColor = true;
            // 
            // btn_consulter_journal_log
            // 
            this.btn_consulter_journal_log.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulter_journal_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consulter_journal_log.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulter_journal_log.Image")));
            this.btn_consulter_journal_log.Location = new System.Drawing.Point(10, 407);
            this.btn_consulter_journal_log.Name = "btn_consulter_journal_log";
            this.btn_consulter_journal_log.Size = new System.Drawing.Size(783, 133);
            this.btn_consulter_journal_log.TabIndex = 2;
            this.btn_consulter_journal_log.Text = "Consulter le journal des Logs";
            this.btn_consulter_journal_log.UseVisualStyleBackColor = true;
            // 
            // btn_gerer_utilsateurs
            // 
            this.btn_gerer_utilsateurs.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerer_utilsateurs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_gerer_utilsateurs.Image = ((System.Drawing.Image)(resources.GetObject("btn_gerer_utilsateurs.Image")));
            this.btn_gerer_utilsateurs.Location = new System.Drawing.Point(10, 268);
            this.btn_gerer_utilsateurs.Name = "btn_gerer_utilsateurs";
            this.btn_gerer_utilsateurs.Size = new System.Drawing.Size(783, 133);
            this.btn_gerer_utilsateurs.TabIndex = 3;
            this.btn_gerer_utilsateurs.Text = "Gérer les Utilisateurs";
            this.btn_gerer_utilsateurs.UseVisualStyleBackColor = true;
            // 
            // lbl_menu_admin
            // 
            this.lbl_menu_admin.AutoSize = true;
            this.lbl_menu_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_menu_admin.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu_admin.Location = new System.Drawing.Point(142, 49);
            this.lbl_menu_admin.Name = "lbl_menu_admin";
            this.lbl_menu_admin.Size = new System.Drawing.Size(521, 43);
            this.lbl_menu_admin.TabIndex = 4;
            this.lbl_menu_admin.Text = "MENU ADMINISTRATEUR";
            // 
            // btn_menu_admin_deconnect
            // 
            this.btn_menu_admin_deconnect.Location = new System.Drawing.Point(660, 12);
            this.btn_menu_admin_deconnect.Name = "btn_menu_admin_deconnect";
            this.btn_menu_admin_deconnect.Size = new System.Drawing.Size(133, 43);
            this.btn_menu_admin_deconnect.TabIndex = 8;
            this.btn_menu_admin_deconnect.Text = "Déconnexion";
            this.btn_menu_admin_deconnect.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 547);
            this.Controls.Add(this.btn_menu_admin_deconnect);
            this.Controls.Add(this.lbl_menu_admin);
            this.Controls.Add(this.btn_gerer_utilsateurs);
            this.Controls.Add(this.btn_consulter_journal_log);
            this.Controls.Add(this.btn_voir_stocks);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_voir_stocks;
		private System.Windows.Forms.Button btn_consulter_journal_log;
		private System.Windows.Forms.Button btn_gerer_utilsateurs;
        private System.Windows.Forms.Label lbl_menu_admin;
        private System.Windows.Forms.Button btn_menu_admin_deconnect;
    }
}