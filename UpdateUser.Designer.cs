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
			// UpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl_titre);
			this.Name = "UpdateUser";
			this.Text = "UpdateUser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_titre;
	}
}