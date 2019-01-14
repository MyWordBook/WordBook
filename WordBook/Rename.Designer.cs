namespace WordBook
{
    partial class Rename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rename));
            this.nowNameLabel = new System.Windows.Forms.Label();
            this.ChangeNametextBox = new System.Windows.Forms.TextBox();
            this.Dobutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nowNameLabel
            // 
            this.nowNameLabel.AutoSize = true;
            this.nowNameLabel.Location = new System.Drawing.Point(68, 49);
            this.nowNameLabel.Name = "nowNameLabel";
            this.nowNameLabel.Size = new System.Drawing.Size(0, 12);
            this.nowNameLabel.TabIndex = 0;
            // 
            // ChangeNametextBox
            // 
            this.ChangeNametextBox.Location = new System.Drawing.Point(37, 74);
            this.ChangeNametextBox.Name = "ChangeNametextBox";
            this.ChangeNametextBox.Size = new System.Drawing.Size(212, 19);
            this.ChangeNametextBox.TabIndex = 1;
            // 
            // Dobutton
            // 
            this.Dobutton.Location = new System.Drawing.Point(104, 108);
            this.Dobutton.Name = "Dobutton";
            this.Dobutton.Size = new System.Drawing.Size(75, 23);
            this.Dobutton.TabIndex = 2;
            this.Dobutton.Text = "Do";
            this.Dobutton.UseVisualStyleBackColor = true;
            this.Dobutton.Click += new System.EventHandler(this.Dobutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(197, 108);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 3;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Alphabet Only";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rename";
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Dobutton);
            this.Controls.Add(this.ChangeNametextBox);
            this.Controls.Add(this.nowNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rename";
            this.Text = "Rename";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rename_FormClosing);
            this.Load += new System.EventHandler(this.Rename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nowNameLabel;
        private System.Windows.Forms.TextBox ChangeNametextBox;
        private System.Windows.Forms.Button Dobutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}