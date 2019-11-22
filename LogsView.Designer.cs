namespace Gestinv
{
    partial class LogsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsView));
            this.lbl_journal_logs = new System.Windows.Forms.Label();
            this.dtgv_journal_logs = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logs_back = new System.Windows.Forms.Button();
            this.btn_logs_deconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_journal_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_journal_logs
            // 
            this.lbl_journal_logs.AutoSize = true;
            this.lbl_journal_logs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_journal_logs.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_journal_logs.Location = new System.Drawing.Point(187, 36);
            this.lbl_journal_logs.Name = "lbl_journal_logs";
            this.lbl_journal_logs.Size = new System.Drawing.Size(417, 43);
            this.lbl_journal_logs.TabIndex = 0;
            this.lbl_journal_logs.Text = "JOURNAL DES LOGS";
            // 
            // dtgv_journal_logs
            // 
            this.dtgv_journal_logs.AllowUserToOrderColumns = true;
            this.dtgv_journal_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_journal_logs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.User,
            this.Type,
            this.Item,
            this.OldValue,
            this.NewValue});
            this.dtgv_journal_logs.Location = new System.Drawing.Point(0, 118);
            this.dtgv_journal_logs.Name = "dtgv_journal_logs";
            this.dtgv_journal_logs.RowHeadersWidth = 51;
            this.dtgv_journal_logs.RowTemplate.Height = 24;
            this.dtgv_journal_logs.Size = new System.Drawing.Size(804, 430);
            this.dtgv_journal_logs.TabIndex = 1;
            this.dtgv_journal_logs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date synchro";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "Utilisateur";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type modif";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // Item
            // 
            this.Item.HeaderText = "Objet modifié";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // OldValue
            // 
            this.OldValue.HeaderText = "Ancienne valeur";
            this.OldValue.MinimumWidth = 6;
            this.OldValue.Name = "OldValue";
            this.OldValue.Width = 125;
            // 
            // NewValue
            // 
            this.NewValue.HeaderText = "Nouvelle valeur";
            this.NewValue.MinimumWidth = 6;
            this.NewValue.Name = "NewValue";
            this.NewValue.Width = 125;
            // 
            // btn_logs_back
            // 
            this.btn_logs_back.Location = new System.Drawing.Point(12, 12);
            this.btn_logs_back.Name = "btn_logs_back";
            this.btn_logs_back.Size = new System.Drawing.Size(133, 43);
            this.btn_logs_back.TabIndex = 6;
            this.btn_logs_back.Text = "Retour Accueil";
            this.btn_logs_back.UseVisualStyleBackColor = true;
            // 
            // btn_logs_deconnect
            // 
            this.btn_logs_deconnect.Location = new System.Drawing.Point(660, 12);
            this.btn_logs_deconnect.Name = "btn_logs_deconnect";
            this.btn_logs_deconnect.Size = new System.Drawing.Size(133, 43);
            this.btn_logs_deconnect.TabIndex = 7;
            this.btn_logs_deconnect.Text = "Déconnexion";
            this.btn_logs_deconnect.UseVisualStyleBackColor = true;
            // 
            // LogsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 547);
            this.Controls.Add(this.btn_logs_deconnect);
            this.Controls.Add(this.btn_logs_back);
            this.Controls.Add(this.dtgv_journal_logs);
            this.Controls.Add(this.lbl_journal_logs);
            this.Name = "LogsView";
            this.Text = "LogsView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_journal_logs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_journal_logs;
        private System.Windows.Forms.DataGridView dtgv_journal_logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewValue;
        private System.Windows.Forms.Button btn_logs_back;
        private System.Windows.Forms.Button btn_logs_deconnect;
    }
}