﻿namespace Gestinv
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
            this.SuspendLayout();
            // 
            // btn_voir_stocks
            // 
            this.btn_voir_stocks.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voir_stocks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voir_stocks.Image = ((System.Drawing.Image)(resources.GetObject("btn_voir_stocks.Image")));
            this.btn_voir_stocks.Location = new System.Drawing.Point(8, 105);
            this.btn_voir_stocks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_voir_stocks.Name = "btn_voir_stocks";
            this.btn_voir_stocks.Size = new System.Drawing.Size(587, 108);
            this.btn_voir_stocks.TabIndex = 1;
            this.btn_voir_stocks.Text = "Voir les Stocks";
            this.btn_voir_stocks.UseVisualStyleBackColor = true;
            this.btn_voir_stocks.Click += new System.EventHandler(this.btn_voir_stocks_Click);
            // 
            // btn_consulter_journal_log
            // 
            this.btn_consulter_journal_log.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulter_journal_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consulter_journal_log.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulter_journal_log.Image")));
            this.btn_consulter_journal_log.Location = new System.Drawing.Point(8, 331);
            this.btn_consulter_journal_log.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_consulter_journal_log.Name = "btn_consulter_journal_log";
            this.btn_consulter_journal_log.Size = new System.Drawing.Size(587, 108);
            this.btn_consulter_journal_log.TabIndex = 2;
            this.btn_consulter_journal_log.Text = "Consulter le journal des Logs";
            this.btn_consulter_journal_log.UseVisualStyleBackColor = true;
            this.btn_consulter_journal_log.Click += new System.EventHandler(this.btn_consulter_journal_log_Click);
            // 
            // btn_gerer_utilsateurs
            // 
            this.btn_gerer_utilsateurs.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerer_utilsateurs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_gerer_utilsateurs.Image = ((System.Drawing.Image)(resources.GetObject("btn_gerer_utilsateurs.Image")));
            this.btn_gerer_utilsateurs.Location = new System.Drawing.Point(8, 218);
            this.btn_gerer_utilsateurs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_gerer_utilsateurs.Name = "btn_gerer_utilsateurs";
            this.btn_gerer_utilsateurs.Size = new System.Drawing.Size(587, 108);
            this.btn_gerer_utilsateurs.TabIndex = 3;
            this.btn_gerer_utilsateurs.Text = "Gérer les Utilisateurs";
            this.btn_gerer_utilsateurs.UseVisualStyleBackColor = true;
            this.btn_gerer_utilsateurs.Click += new System.EventHandler(this.btn_gerer_utilsateurs_Click);
            // 
            // lbl_menu_admin
            // 
            this.lbl_menu_admin.AutoSize = true;
            this.lbl_menu_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_menu_admin.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu_admin.Location = new System.Drawing.Point(106, 40);
            this.lbl_menu_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_menu_admin.Name = "lbl_menu_admin";
            this.lbl_menu_admin.Size = new System.Drawing.Size(421, 34);
            this.lbl_menu_admin.TabIndex = 4;
            this.lbl_menu_admin.Text = "MENU ADMINISTRATEUR";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 447);
            this.Controls.Add(this.lbl_menu_admin);
            this.Controls.Add(this.btn_gerer_utilsateurs);
            this.Controls.Add(this.btn_consulter_journal_log);
            this.Controls.Add(this.btn_voir_stocks);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
    }
}