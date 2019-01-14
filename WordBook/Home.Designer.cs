namespace WordBook
{
    partial class Home
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
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ほめるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Homepanel = new System.Windows.Forms.Panel();
            this.Homebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上書き保存ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.testToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // ほめるToolStripMenuItem
            // 
            this.ほめるToolStripMenuItem.Name = "ほめるToolStripMenuItem";
            this.ほめるToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ほめるToolStripMenuItem.Text = "褒める(&H)";
            // 
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
            this.Homebutton.FlatAppearance.BorderSize = 0;
            this.Homebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Homebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebutton.Image = global::WordBook.Properties.Resources.Home1;
            this.Homebutton.Location = new System.Drawing.Point(228, -3);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(60, 60);
            this.Homebutton.TabIndex = 8;
            this.Homebutton.UseVisualStyleBackColor = true;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click_1);
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(520, 584);
            this.Controls.Add(this.Homebutton);
            this.Controls.Add(this.Homepanel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Home";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ほめるToolStripMenuItem;
        private System.Windows.Forms.Panel Homepanel;
        private System.Windows.Forms.Button Homebutton;
    }
}

