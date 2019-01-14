using System;
using System.Drawing;

namespace WordBook
{
    partial class PlayLabel
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
            this.Answer = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EditCombo = new System.Windows.Forms.ComboBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.FirstText = new System.Windows.Forms.TextBox();
            this.AdditionText = new System.Windows.Forms.TextBox();
            this.SecondText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Audiobutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscriptiontextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Answer.CausesValidation = false;
            this.Answer.FlatAppearance.BorderSize = 0;
            this.Answer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Answer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Answer.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Answer.Location = new System.Drawing.Point(203, 450);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(104, 39);
            this.Answer.TabIndex = 1;
            this.Answer.Text = "Answer";
            this.Answer.UseVisualStyleBackColor = false;
            this.Answer.Visible = false;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Nextbutton.FlatAppearance.BorderSize = 0;
            this.Nextbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Nextbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Nextbutton.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nextbutton.Location = new System.Drawing.Point(390, 450);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(0);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(80, 39);
            this.Nextbutton.TabIndex = 4;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nextbutton.UseVisualStyleBackColor = false;
            this.Nextbutton.Visible = false;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            this.Nextbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Audiobutton_KeyDown);
            // 
            // EditCombo
            // 
            this.EditCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditCombo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditCombo.FormattingEnabled = true;
            this.EditCombo.Items.AddRange(new object[] {
            "Edit",
            "Delete"});
            this.EditCombo.Location = new System.Drawing.Point(349, 0);
            this.EditCombo.Name = "EditCombo";
            this.EditCombo.Size = new System.Drawing.Size(121, 26);
            this.EditCombo.TabIndex = 6;
            this.EditCombo.Visible = false;
            this.EditCombo.SelectedIndexChanged += new System.EventHandler(this.EditCombo_SelectedIndexChanged);
            this.EditCombo.Click += new System.EventHandler(this.EditCombo_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Startbutton.Location = new System.Drawing.Point(380, 484);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(90, 23);
            this.Startbutton.TabIndex = 7;
            this.Startbutton.Text = "Start(Enter)";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            this.Startbutton.LostFocus += new System.EventHandler(this.Startbutton_LostFocus);
            // 
            // FirstText
            // 
            this.FirstText.AcceptsReturn = true;
            this.FirstText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FirstText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstText.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FirstText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FirstText.Location = new System.Drawing.Point(3, 32);
            this.FirstText.Multiline = true;
            this.FirstText.Name = "FirstText";
            this.FirstText.ReadOnly = true;
            this.FirstText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FirstText.Size = new System.Drawing.Size(488, 120);
            this.FirstText.TabIndex = 10;
            this.FirstText.Visible = false;
            // 
            // AdditionText
            // 
            this.AdditionText.BackColor = System.Drawing.SystemColors.Control;
            this.AdditionText.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AdditionText.Location = new System.Drawing.Point(3, 323);
            this.AdditionText.Multiline = true;
            this.AdditionText.Name = "AdditionText";
            this.AdditionText.ReadOnly = true;
            this.AdditionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AdditionText.Size = new System.Drawing.Size(488, 100);
            this.AdditionText.TabIndex = 11;
            this.AdditionText.Visible = false;
            // 
            // SecondText
            // 
            this.SecondText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SecondText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondText.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SecondText.Location = new System.Drawing.Point(6, 179);
            this.SecondText.Multiline = true;
            this.SecondText.Name = "SecondText";
            this.SecondText.ReadOnly = true;
            this.SecondText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SecondText.Size = new System.Drawing.Size(488, 120);
            this.SecondText.TabIndex = 12;
            this.SecondText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "FirstText";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "SecondText";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(5, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Addition";
            this.label3.Visible = false;
            // 
            // Audiobutton
            // 
            this.Audiobutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Audiobutton.FlatAppearance.BorderSize = 0;
            this.Audiobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Audiobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Audiobutton.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Audiobutton.Location = new System.Drawing.Point(203, 450);
            this.Audiobutton.Name = "Audiobutton";
            this.Audiobutton.Size = new System.Drawing.Size(104, 39);
            this.Audiobutton.TabIndex = 17;
            this.Audiobutton.Text = "Replay";
            this.Audiobutton.UseVisualStyleBackColor = false;
            this.Audiobutton.Visible = false;
            this.Audiobutton.Click += new System.EventHandler(this.Audiobutton_Click);
            this.Audiobutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Audiobutton_KeyDown);
            this.Audiobutton.LostFocus += new System.EventHandler(this.Audiobutton_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(304, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Menu";
            this.label4.Visible = false;
            // 
            // DiscriptiontextBox
            // 
            this.DiscriptiontextBox.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DiscriptiontextBox.Location = new System.Drawing.Point(23, 3);
            this.DiscriptiontextBox.Multiline = true;
            this.DiscriptiontextBox.Name = "DiscriptiontextBox";
            this.DiscriptiontextBox.ReadOnly = true;
            this.DiscriptiontextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DiscriptiontextBox.Size = new System.Drawing.Size(447, 458);
            this.DiscriptiontextBox.TabIndex = 19;
            this.DiscriptiontextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscriptiontextBox_KeyDown);
            // 
            // PlayLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdditionText);
            this.Controls.Add(this.FirstText);
            this.Controls.Add(this.EditCombo);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.SecondText);
            this.Controls.Add(this.Audiobutton);
            this.Controls.Add(this.DiscriptiontextBox);
            this.Controls.Add(this.Answer);
            this.Name = "PlayLabel";
            this.Size = new System.Drawing.Size(497, 510);
            this.Load += new System.EventHandler(this.PlayLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox EditCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiscriptiontextBox;
        public System.Windows.Forms.Button Nextbutton;
        public System.Windows.Forms.Button Startbutton;
        public System.Windows.Forms.Button Audiobutton;
        public System.Windows.Forms.Button Answer;
        public System.Windows.Forms.TextBox FirstText;
        public System.Windows.Forms.TextBox AdditionText;
        public System.Windows.Forms.TextBox SecondText;
    }
}
