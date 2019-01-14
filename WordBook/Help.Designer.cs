namespace WordBook
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.Closebutton = new System.Windows.Forms.Button();
            this.HelprichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Closebutton
            // 
            this.Closebutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Closebutton.Location = new System.Drawing.Point(445, 513);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(93, 23);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.Text = "Close(Enter)";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // HelprichTextBox
            // 
            this.HelprichTextBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HelprichTextBox.Location = new System.Drawing.Point(12, 12);
            this.HelprichTextBox.Name = "HelprichTextBox";
            this.HelprichTextBox.Size = new System.Drawing.Size(550, 491);
            this.HelprichTextBox.TabIndex = 2;
            this.HelprichTextBox.Text = "";
            this.HelprichTextBox.TextChanged += new System.EventHandler(this.HelprichTextBox_TextChanged);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 548);
            this.Controls.Add(this.HelprichTextBox);
            this.Controls.Add(this.Closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Help";
            this.Text = "Help";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Help_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.RichTextBox HelprichTextBox;
    }
}