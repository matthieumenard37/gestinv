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
            this.btn_logs_back = new System.Windows.Forms.Button();
            this.btn_logs_deconnect = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lbl_journal_logs
            // 
            this.lbl_journal_logs.AutoSize = true;
            this.lbl_journal_logs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_journal_logs.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_journal_logs.Location = new System.Drawing.Point(140, 29);
            this.lbl_journal_logs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_journal_logs.Name = "lbl_journal_logs";
            this.lbl_journal_logs.Size = new System.Drawing.Size(337, 34);
            this.lbl_journal_logs.TabIndex = 0;
            this.lbl_journal_logs.Text = "JOURNAL DES LOGS";
            // 
            // btn_logs_back
            // 
            this.btn_logs_back.Location = new System.Drawing.Point(9, 10);
            this.btn_logs_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logs_back.Name = "btn_logs_back";
            this.btn_logs_back.Size = new System.Drawing.Size(100, 35);
            this.btn_logs_back.TabIndex = 6;
            this.btn_logs_back.Text = "Retour Accueil";
            this.btn_logs_back.UseVisualStyleBackColor = true;
            // 
            // btn_logs_deconnect
            // 
            this.btn_logs_deconnect.Location = new System.Drawing.Point(495, 10);
            this.btn_logs_deconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logs_deconnect.Name = "btn_logs_deconnect";
            this.btn_logs_deconnect.Size = new System.Drawing.Size(100, 35);
            this.btn_logs_deconnect.TabIndex = 7;
            this.btn_logs_deconnect.Text = "Déconnexion";
            this.btn_logs_deconnect.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2, 81);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(600, 363);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // LogsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 444);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_logs_deconnect);
            this.Controls.Add(this.btn_logs_back);
            this.Controls.Add(this.lbl_journal_logs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogsView";
            this.Text = "LogsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_journal_logs;
        private System.Windows.Forms.Button btn_logs_back;
        private System.Windows.Forms.Button btn_logs_deconnect;
        private System.Windows.Forms.TreeView treeView1;
    }
}