namespace WordBook
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.Nobutton = new System.Windows.Forms.Button();
            this.Yesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete this data?";
            // 
            // Nobutton
            // 
            this.Nobutton.Location = new System.Drawing.Point(148, 84);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(75, 23);
            this.Nobutton.TabIndex = 1;
            this.Nobutton.Text = "No";
            this.Nobutton.UseVisualStyleBackColor = true;
            this.Nobutton.Click += new System.EventHandler(this.Nobutton_Click);
            // 
            // Yesbutton
            // 
            this.Yesbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Yesbutton.Location = new System.Drawing.Point(48, 84);
            this.Yesbutton.Name = "Yesbutton";
            this.Yesbutton.Size = new System.Drawing.Size(75, 23);
            this.Yesbutton.TabIndex = 2;
            this.Yesbutton.Text = "Yes";
            this.Yesbutton.UseVisualStyleBackColor = true;
            this.Yesbutton.Click += new System.EventHandler(this.Yesbutton_Click);
            // 
            // Delete
            // 
            this.AcceptButton = this.Nobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Yesbutton;
            this.ClientSize = new System.Drawing.Size(275, 137);
            this.Controls.Add(this.Yesbutton);
            this.Controls.Add(this.Nobutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nobutton;
        private System.Windows.Forms.Button Yesbutton;
    }
}