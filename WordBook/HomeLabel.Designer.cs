namespace WordBook
{
    partial class HomeLabel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CategorylistBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Createbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.Runbutton = new System.Windows.Forms.Button();
            this.QuestionNumbertextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.RepeattextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HelplinkLabel = new System.Windows.Forms.LinkLabel();
            this.CategorySortComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategorylistBox
            // 
            this.CategorylistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategorylistBox.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CategorylistBox.FormattingEnabled = true;
            this.CategorylistBox.ItemHeight = 23;
            this.CategorylistBox.Location = new System.Drawing.Point(27, 48);
            this.CategorylistBox.Name = "CategorylistBox";
            this.CategorylistBox.Size = new System.Drawing.Size(438, 299);
            this.CategorylistBox.TabIndex = 2;
            this.CategorylistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategorylistBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // Createbutton
            // 
            this.Createbutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Createbutton.Location = new System.Drawing.Point(127, 19);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(137, 23);
            this.Createbutton.TabIndex = 4;
            this.Createbutton.Text = "CategorytCreate(C)";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(326, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = " Category Menu ";
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorycomboBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Items.AddRange(new object[] {
            "Delete",
            "CategoryEdit",
            "Add"});
            this.CategorycomboBox.Location = new System.Drawing.Point(329, 472);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(110, 26);
            this.CategorycomboBox.TabIndex = 7;
            this.CategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.CategorycomboBox_SelectedIndexChanged);
            // 
            // Runbutton
            // 
            this.Runbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Runbutton.FlatAppearance.BorderSize = 0;
            this.Runbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Runbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Runbutton.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Runbutton.Location = new System.Drawing.Point(186, 362);
            this.Runbutton.Name = "Runbutton";
            this.Runbutton.Size = new System.Drawing.Size(121, 60);
            this.Runbutton.TabIndex = 9;
            this.Runbutton.Text = "Run";
            this.Runbutton.UseVisualStyleBackColor = false;
            this.Runbutton.Click += new System.EventHandler(this.Runbutton_Click_1);
            // 
            // QuestionNumbertextBox
            // 
            this.QuestionNumbertextBox.Location = new System.Drawing.Point(164, 452);
            this.QuestionNumbertextBox.Name = "QuestionNumbertextBox";
            this.QuestionNumbertextBox.Size = new System.Drawing.Size(28, 19);
            this.QuestionNumbertextBox.TabIndex = 10;
            this.QuestionNumbertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuestionNumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuestionNumbertextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(50, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Questions";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(50, 480);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 18);
            this.label.TabIndex = 13;
            this.label.Text = "Repeat";
            // 
            // RepeattextBox
            // 
            this.RepeattextBox.Location = new System.Drawing.Point(164, 479);
            this.RepeattextBox.Name = "RepeattextBox";
            this.RepeattextBox.Size = new System.Drawing.Size(28, 19);
            this.RepeattextBox.TabIndex = 12;
            this.RepeattextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RepeattextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(42, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 2);
            this.label3.TabIndex = 17;
            // 
            // HelplinkLabel
            // 
            this.HelplinkLabel.AutoSize = true;
            this.HelplinkLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HelplinkLabel.Location = new System.Drawing.Point(437, 350);
            this.HelplinkLabel.Name = "HelplinkLabel";
            this.HelplinkLabel.Size = new System.Drawing.Size(34, 18);
            this.HelplinkLabel.TabIndex = 18;
            this.HelplinkLabel.TabStop = true;
            this.HelplinkLabel.Text = "Help";
            this.HelplinkLabel.Click += new System.EventHandler(this.HelplinkLabel_Click);
            // 
            // CategorySortComboBox
            // 
            this.CategorySortComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Late",
            "Old",
            "ABC"});
            this.CategorySortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorySortComboBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CategorySortComboBox.FormattingEnabled = true;
            this.CategorySortComboBox.Items.AddRange(new object[] {
            "Late",
            "Old",
            "ABC"});
            this.CategorySortComboBox.Location = new System.Drawing.Point(394, 16);
            this.CategorySortComboBox.Name = "CategorySortComboBox";
            this.CategorySortComboBox.Size = new System.Drawing.Size(71, 26);
            this.CategorySortComboBox.TabIndex = 19;
            this.CategorySortComboBox.SelectedIndexChanged += new System.EventHandler(this.CategorySortComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(355, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sort";
            // 
            // HomeLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategorySortComboBox);
            this.Controls.Add(this.HelplinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.RepeattextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuestionNumbertextBox);
            this.Controls.Add(this.Runbutton);
            this.Controls.Add(this.CategorycomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.CategorylistBox);
            this.Controls.Add(this.label2);
            this.Name = "HomeLabel";
            this.Size = new System.Drawing.Size(490, 510);
            this.Load += new System.EventHandler(this.HomeLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        public System.Windows.Forms.ListBox CategorylistBox;
        public System.Windows.Forms.Button Runbutton;
        private System.Windows.Forms.TextBox QuestionNumbertextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox RepeattextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel HelplinkLabel;
        private System.Windows.Forms.ComboBox CategorySortComboBox;
        private System.Windows.Forms.Label label5;
    }
}
