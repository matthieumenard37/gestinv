namespace Gestinv
{
    partial class AddFamily
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
            this.lbl_add_family = new System.Windows.Forms.Label();
            this.txtBox_family_name = new System.Windows.Forms.TextBox();
            this.lbl_family_name = new System.Windows.Forms.Label();
            this.btn_add_family = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_add_family
            // 
            this.lbl_add_family.AutoSize = true;
            this.lbl_add_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_family.Location = new System.Drawing.Point(171, 9);
            this.lbl_add_family.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_add_family.Name = "lbl_add_family";
            this.lbl_add_family.Size = new System.Drawing.Size(158, 22);
            this.lbl_add_family.TabIndex = 0;
            this.lbl_add_family.Text = "Ajouter une famille";
            this.lbl_add_family.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_family_name
            // 
            this.txtBox_family_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_family_name.Location = new System.Drawing.Point(131, 46);
            this.txtBox_family_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox_family_name.Name = "txtBox_family_name";
            this.txtBox_family_name.Size = new System.Drawing.Size(250, 26);
            this.txtBox_family_name.TabIndex = 1;
            // 
            // lbl_family_name
            // 
            this.lbl_family_name.AutoSize = true;
            this.lbl_family_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_family_name.Location = new System.Drawing.Point(11, 49);
            this.lbl_family_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_family_name.Name = "lbl_family_name";
            this.lbl_family_name.Size = new System.Drawing.Size(116, 17);
            this.lbl_family_name.TabIndex = 2;
            this.lbl_family_name.Text = "Nom de la famille";
            // 
            // btn_add_family
            // 
            this.btn_add_family.Location = new System.Drawing.Point(394, 46);
            this.btn_add_family.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_family.Name = "btn_add_family";
            this.btn_add_family.Size = new System.Drawing.Size(65, 26);
            this.btn_add_family.TabIndex = 3;
            this.btn_add_family.Text = "Créer";
            this.btn_add_family.UseVisualStyleBackColor = true;
            this.btn_add_family.Click += new System.EventHandler(this.btn_add_family_Click);
            // 
            // AddFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 103);
            this.Controls.Add(this.btn_add_family);
            this.Controls.Add(this.lbl_family_name);
            this.Controls.Add(this.txtBox_family_name);
            this.Controls.Add(this.lbl_add_family);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddFamily";
            this.Text = "AddFamily";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_add_family;
        private System.Windows.Forms.TextBox txtBox_family_name;
        private System.Windows.Forms.Label lbl_family_name;
        private System.Windows.Forms.Button btn_add_family;
    }
}