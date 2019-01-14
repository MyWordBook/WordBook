namespace WordBook
{
    partial class TextList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextList));
            this.label1 = new System.Windows.Forms.Label();
            this.SentenceListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstSentence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text List";
            // 
            // SentenceListView
            // 
            this.SentenceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstSentence});
            this.SentenceListView.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SentenceListView.FullRowSelect = true;
            this.SentenceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SentenceListView.Location = new System.Drawing.Point(12, 60);
            this.SentenceListView.Name = "SentenceListView";
            this.SentenceListView.Size = new System.Drawing.Size(375, 384);
            this.SentenceListView.TabIndex = 2;
            this.SentenceListView.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "【ID】";
            // 
            // FirstSentence
            // 
            this.FirstSentence.Text = "【FIRST SENTENCE】";
            this.FirstSentence.Width = 300;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Deletebutton.Location = new System.Drawing.Point(141, 459);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Delete(D)";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Editbutton.Location = new System.Drawing.Point(222, 459);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 5;
            this.Editbutton.Text = "Edit(E)";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Closebutton.Location = new System.Drawing.Point(312, 31);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 23);
            this.Closebutton.TabIndex = 6;
            this.Closebutton.Text = "Close(C)";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Addbutton.Location = new System.Drawing.Point(303, 459);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "Add(A)";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // TextList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 494);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.SentenceListView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TextList";
            this.Text = "TextList";
            this.Load += new System.EventHandler(this.TextList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextList_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView SentenceListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstSentence;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Addbutton;
    }
}