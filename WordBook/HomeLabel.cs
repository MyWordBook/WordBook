using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.SmallBasic.Library;


namespace WordBook
{

    //ホーム画面
    public partial class HomeLabel : UserControl
    {
        DataCenter dc;
        PlayLabel  pl ;

        public HomeLabel()
        {
            InitializeComponent();
        }
        //ロード
        private void HomeLabel_Load(object sender, EventArgs e)
        {
            //参照クラス
            dc = new DataCenter();
            pl = new PlayLabel();
            //ロード時のfocusなど
            if (CategorylistBox.Items.Count > 0) CategorylistBox.SetSelected(0, true);
            this.ActiveControl = this.CategorylistBox;
            this.CategorylistBox.Focus();
            QuestionNumbertextBox.Text = "5";　//出題数のデフォルト
            RepeattextBox.Text = "1";　　　　  　//リピート回数のデフォルト
        }

        //"Run"実行ボタン
        public void Runbutton_Click_1(object sender, EventArgs e)
        {
            Sound.PlayClickAndWait();　//クリック音

            //選択したカテゴリーがデータを持っていない場合は抜ける
            string tableName = CategorylistBox.SelectedItem.ToString();
            bool categoryData = dc.HasTableData(tableName);
            if (!categoryData)
            {
                MessageBox.Show("No Data,  You Need to go 'Add'");
                return;
            }

            //各項目の入力が揃っているかチェック、プロパティに代入
            if (!string.IsNullOrEmpty(CategorylistBox.Text) || !string.IsNullOrEmpty(QuestionNumbertextBox.Text) 
                || !string.IsNullOrEmpty(RepeattextBox.Text))
            {
                DicidedInformation.UsingTable     = CategorylistBox.Text;
                DicidedInformation.QuestionNumber = int.Parse(QuestionNumbertextBox.Text);
                DicidedInformation.RepeatNumber   = int.Parse(RepeattextBox.Text);

                HomeSave.homeLabel.Visible = false;
                HomeSave.playLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Input Informations");
            }
        }

        //Createボタン　新規テーブルを作成してデータベースと表示リストボックスへ追加する
        public void Createbutton_Click(object sender, EventArgs e)
        {
            //記入されたテキストを取得
            string name = CreateCategory.CreateMiniForm();
            if (!string.IsNullOrEmpty(name))
            {
                CategorylistBox.Items.Add(name);
                dc.CreateNewTable(name);

                List<string> tableList = dc.GetSortedTable("Late");
                HomeSave.CategoryListUpdate(tableList);
            }
            this.ActiveControl = this.Runbutton;
        }

        //カテゴリーメニューコンボボックス　
        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択メニューを取得
            string selectedItem = CategorycomboBox.SelectedItem.ToString();
            //変更を加えるテーブル名を取得
            string selectedTable = CategorylistBox.SelectedItem.ToString();
            //QuestionEditionで使用するため値を入れる
            DicidedInformation.UsingTable = selectedTable;  

            switch (selectedItem)
            {
                //Addの場合、テーブルにSentenceを追加
                case "Add":
                    //テーブル名を指定してAddダイアログを表示
                    var add = new Add(selectedTable);
                    //----------------//
                    //更新
                    TextList.TextListMiniForm(selectedTable);
                    break;

                //Deleteの場合、テーブルを削除する
                case "Delete":
                    //本当に削除するか確認する
                    bool doDelete = Delete.DeleteMiniForm();
                    //リストボックスと2つのデータベースより削除
                    if (doDelete)
                    {
                        CategorylistBox.Items.Remove(selectedTable);
                        CategorylistBox.Update();
                        dc.DeleteTable(selectedTable);
                        dc.DeleteTable(selectedTable + "_Ebbinghaus");
                    }
                    break;

                //CategoryEditの場合、Sentence一覧が見れるTextListダイアログを開く
                case "CategoryEdit":
                    //カテゴリーがデータを持っていない場合は抜ける
                    bool categoryData = dc.HasTableData(selectedTable);
                    if (categoryData)
                    {
                        TextList.TextListMiniForm(selectedTable);
                    }
                    else
                    {
                        MessageBox.Show("No Data , You Need to go 'Add'");
                    }
                    break;
            }
            CategorylistBox.Update();
            this.ActiveControl = this.Runbutton;
        }

        //出題テキストボックスの入力制限
        private void QuestionNumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl(sender, e);
        }
        //繰り返しテキストボックスの入力制限
        private void RepeatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl(sender, e);
        }
        private void InputControl(object sender, KeyPressEventArgs e)
        {
            //押されたキーが 0～9でない場合は、イベントをキャンセルする
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
            //backspaceは使用可能
            if ((e.KeyChar & (char)Keys.Back) == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        //キーイベント
        private void CategorylistBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.C:
                    Createbutton_Click(this, e);
                    break;

                case Keys.Enter:
                    Runbutton_Click_1(this, e);
                    break;
            }
        }

        //フォーカスはカテゴリーリストボックス
        private void CategorylistBox_LostFocus(object sender, EventArgs e)
        {
            if (this.Visible) CategorylistBox.Focus();
        }

        //カテゴリーリストの並べ替えメソッド　
        private void CategorySortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択メニューを取得
            string selectedItem = CategorySortComboBox.SelectedItem.ToString();

            List<string> tableList = dc.GetSortedTable(selectedItem);
            HomeSave.CategoryListUpdate(tableList);

            CategorylistBox.SetSelected(0, true);
            this.ActiveControl = this.CategorylistBox;
        }

        //Helpウィンドウ
        private void HelplinkLabel_Click(object sender, EventArgs e)
        {
            var help = new Help()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            CategorylistBox.Focus();
        }
    }
}
