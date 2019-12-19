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
            this.Controls.Add(this.lbl_journal_logs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogsView";
            this.Text = "LogsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_journal_logs;
        private System.Windows.Forms.TreeView treeView1;
    }
}