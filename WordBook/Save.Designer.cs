namespace WordBook
{
    partial class Save
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Save));
            this.label1 = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Nobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to save the changes?";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(37, 87);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 1;
            this.Savebutton.Text = "Yes";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Nobutton
            // 
            this.Nobutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Nobutton.Location = new System.Drawing.Point(129, 87);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(75, 23);
            this.Nobutton.TabIndex = 2;
            this.Nobutton.Text = "No";
            this.Nobutton.UseVisualStyleBackColor = true;
            this.Nobutton.Click += new System.EventHandler(this.Nobutton_Click);
            // 
            // Save
            // 
            this.AcceptButton = this.Savebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Nobutton;
            this.ClientSize = new System.Drawing.Size(239, 136);
            this.Controls.Add(this.Nobutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Save";
            this.Text = "Save";
            this.Load += new System.EventHandler(this.Save_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Save_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Nobutton;
    }
}