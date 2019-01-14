using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBook
{
    public partial class TextList : Form
    {
        DataCenter dc;
        private string TableName;

        //HomeLabelよりテーブルネームを受け取る
        public TextList(string tableName)
        {
            InitializeComponent();
            TableName = tableName;
            SentenceListView.View = View.Details;
            //受け取ったテーブル名のすべての行を表示
            ListViewDipslay();
        }

        //最初と最後に呼ばれる
        static public void TextListMiniForm(string tableName)
        {
            TextList categoryList = new TextList(tableName)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            categoryList.ShowDialog();
        }

        private void TextList_Load(object sender, EventArgs e)
        {
            SentenceListView.Select();
            this.ActiveControl = this.SentenceListView;
        }
        //編集ボタン
        private void Editbutton_Click(object sender, EventArgs e)
        {
            //選択されたリストよりIdを読み込み行を取得
            if (SentenceListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select !");
                return;
            }
            //選択した行のIdを取得
            var selectedItem = SentenceListView.SelectedItems[0];
            int id = int.Parse(selectedItem.Text);
            //行情報をもらう　row[id,first,second,addi,audi]
            string[] row = dc.GetRow(TableName, id);

            //RowEditionへ送る
            QuestionEdition qEdit = new QuestionEdition();
            //変更がない場合はnullが返ってくる
            string[] comebackTexts = qEdit.CategoryListUpdateMiniForm(row);
            //comebackTextsがnullではない場合に変更されたものを受け取り、データセンターを更新　
            if (comebackTexts!=null)
            {
                dc.EditRow(TableName, comebackTexts[0], comebackTexts[1], comebackTexts[2], comebackTexts[3], id);
                //リスト表示を更新
                selectedItem.SubItems[1].Text = comebackTexts[0];
                SentenceListView.Update();
            }
        }
        //Closeボタン
        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Addボタン 
        private void Addbutton_Click(object sender, EventArgs e)
        {
            //テーブル名を指定してAddダイアログを表示
            Add add = new Add(TableName);
            //----------------//
            //更新
            SentenceListView.Items.Clear();
            ListViewDipslay();
        }
        //Deleteボタン
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            bool doDelete = Delete.DeleteMiniForm();
            //セレクトされたリストビューのIdを使ってデータ消去
            var selectedItem = SentenceListView.SelectedItems[0];
            int id = int.Parse(selectedItem.Text);
            if (doDelete)
            {
                dc.DeleteRow(TableName, id);
                //更新
                SentenceListView.Items.Clear();
                ListViewDipslay();
            }
        }
        //ディスプレイへの表示メソッド
        private void ListViewDipslay()
        {
            dc = new DataCenter();
            var IdList = dc.GetIdList(TableName);

            foreach (var idList in IdList)
            {
                //Idに応じたFirstSentenceを取得して
                var first = dc.FirstSentenceForListDisplay(TableName, Convert.ToInt32(idList));
                //リストビューへ表示
                var listViewItems = new ListViewItem();
                listViewItems = SentenceListView.Items.Add(idList.ToString());
                listViewItems.SubItems.Add(first);
            }
        }
        //キーイベント
        private void TextList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                case Keys.C:
                    Closebutton_Click(this, e);
                    break;
                case Keys.Enter:
                case Keys.Space:
                case Keys.A:
                    Addbutton_Click(this, e);
                    break;
                case Keys.D:
                    Deletebutton_Click(this, e);
                    break;
                case Keys.E:
                    Editbutton_Click(this, e);
                    break;
            }
        }
    }
}
