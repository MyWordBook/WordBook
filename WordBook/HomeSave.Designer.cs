namespace WordBook
{
    partial class HomeSave
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSave));
            this.Homepanel = new System.Windows.Forms.Panel();
            this.Homebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Homepanel
            // 
            this.Homepanel.Location = new System.Drawing.Point(12, 63);
            this.Homepanel.Name = "Homepanel";
            this.Homepanel.Size = new System.Drawing.Size(496, 510);
            this.Homepanel.TabIndex = 3;
            // 
            // Homebutton
            // 
            this.Homebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Homebutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Homebutton.FlatAppearance.BorderSize = 0;
            this.Homebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Homebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Homebutton.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Homebutton.Location = new System.Drawing.Point(28, 15);
            this.Homebutton.Margin = new System.Windows.Forms.Padding(0);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(151, 45);
            this.Homebutton.TabIndex = 8;
            this.Homebutton.Text = "HOME";
            this.Homebutton.UseVisualStyleBackColor = false;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click_1);
            // 
            // HomeSave
            // 
            this.ClientSize = new System.Drawing.Size(520, 584);
            this.Controls.Add(this.Homebutton);
            this.Controls.Add(this.Homepanel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeSave";
            this.Text = "HOME";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Homepanel;
        private System.Windows.Forms.Button Homebutton;
    }
}

