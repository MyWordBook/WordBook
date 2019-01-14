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
    public partial class HomeSave : Form
    {
        public static HomeLabel homeLabel;
        public static PlayLabel playLabel;
        public static Add addWindow;
        public DataCenter dc;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeSave());
        }
        //コンストラクター
        public HomeSave()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            List<string> tableList = dc.GetSortedTable("Late");
            CategoryListUpdate(tableList);
        }

        //取得したテーブル名一覧をカテゴリーリストへ表示
        static public void CategoryListUpdate(List<string> tableList)
        {
            homeLabel.CategorylistBox.Items.Clear();
            //データベース内にあるテーブル名一覧を取得
            foreach (var tablelist in tableList)
            {
                if (!tablelist.Contains("_Ebbinghaus"))  //"_Ebbinghaus"(出題テーブル)は表示させない
                    homeLabel.CategorylistBox.Items.Add(tablelist);
            }
            homeLabel.CategorylistBox.Update();
        }
        //Homeボタン
        private void Homebutton_Click_1(object sender, EventArgs e)
        {
            //アプリケーションを再起動する
            Application.Restart();
            Application.Exit();
        }
    }
}
