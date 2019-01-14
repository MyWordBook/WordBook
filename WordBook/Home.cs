using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.SmallBasic.Library;


namespace WordBook
{

    public partial class Home : Form
    {
        public static HomeLabel homeLabel;
        public static PlayLabel playLabel;
        public static Add addWindow;
        public DataCenter dc;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        public Home()
        {
            InitializeComponent();
            homeLabel = new HomeLabel();
            playLabel = new PlayLabel();

            //ホームパネルにラベルを追加
            Homepanel.Controls.Add(homeLabel);
            Homepanel.Controls.Add(playLabel);

            //最初はhomeLabelを表示
            homeLabel.Visible = true;
            playLabel.Visible = false;

            //カテゴリーリストを取得
            dc = new DataCenter();
            dc.GetTable();
            CategoryListControl(dc.TableList);

            //Homeボタン画像指定
            Bitmap Home4 = Properties.Resources.Home3;
            Homebutton.Image = Home4;
        }
        //取得したテーブル名一覧をカテゴリーリストへ表示
        private void CategoryListControl(ArrayList tableList)
        {
            homeLabel.CategorylistBox.Items.Clear();
            //データベース内にあるテーブル名一覧を取得
            foreach (var tablelist in tableList)
            {
                homeLabel.CategorylistBox.Items.Add(tablelist);
            }
            homeLabel.CategorylistBox.Update();
        }
        //Homeボタン
        private void Homebutton_Click_1(object sender, EventArgs e)
        {
            homeLabel.Visible = true;
            playLabel.Visible = false;
        }

        //キーイベント
        public void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.C|| e.KeyData == Keys.A)

            {

                switch (e.KeyData)
                {

                    case Keys.Enter:
                        //PlayLabel時
                        if (playLabel.Visible)
                        {
                            if (playLabel.Startbutton.Visible)
                            {
                                this.KeyDown += playLabel.Startbutton_Click;
                            }
                            else if (playLabel.Answer.Visible)
                            {
                                this.KeyDown += playLabel.Answer_Click;
                            }
                            else if (playLabel.Audiobutton.Visible && playLabel.Audiobutton.Enabled)
                            {
                                this.KeyDown += playLabel.Audiobutton_Click;
                            }

                            //HomeLabel時
                        }
                        else if (homeLabel.Visible)
                        {
                            this.KeyDown += homeLabel.Runbutton_Click_1;
                        }
                        break;

                    case Keys.C:
                        if(homeLabel.Visible)this.KeyDown += homeLabel.Createbutton_Click;
                        break;
                    case Keys.S:
                        if (playLabel.Visible) this.KeyDown += playLabel.Nextbutton_Click;
                        break;
                }
            }
        }


    }
}
