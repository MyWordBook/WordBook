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
    public partial class QuestionEdition : Form
    {
        private string[] argumentValues; 　  //受け取った引数入れる
        public string[] ReturnValues;       //返す戻り値入れる
        private string[] receiveTexts;
        public bool isClose;
        public bool goSaveForm = true;

        private QuestionEdition questionEdition;
        Save save;

        //コンストラクタ（ShowMiniFormの次に呼ばれる）
        public QuestionEdition(params string[] argumentValues)
        {
            InitializeComponent();
            goSaveForm = true;
            save = new Save();
            isClose = false;
            ReturnValues = new string[4];
            this.argumentValues = argumentValues;
        }
        //ラベルをロード
        private void RowEdition_Load(object sender, EventArgs e)
        {
            //送られてきたテキストをテキストボックスへ表示 
            this.firstRowEdit.Text = argumentValues[1];
            this.secondRowEdit.Text = argumentValues[2];
            this.addiEdit.Text = argumentValues[3];
            this.soundUrlEdit.Text = argumentValues[4];
            this.CategoryName.Text = DicidedInformation.UsingTable.ToString();

        }

        //Closeボタン
        private void CloseButton_Click(object sender, EventArgs e)
        {
            goSaveForm = false;
            this.isClose = true;
            this.Close();
        }

        //Updateボタン テキストボックス内にあるテキストをReturnValuesへ格納
        public void Updatebutton_Click(object sender, EventArgs e)
        {
            this.ReturnValues[0] = firstRowEdit.Text;
            this.ReturnValues[1] = secondRowEdit.Text;
            this.ReturnValues[2] = addiEdit.Text;
            this.ReturnValues[3] = soundUrlEdit.Text;

            goSaveForm = false;
            this.Close();
        }

        //最初と最後に呼ばれる
        public string[] UpdateMiniForm(string[] s)
        {
            //PlayLabelから受け取った引数をコンストラクタへ渡す
            questionEdition = new QuestionEdition(s)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            questionEdition.ShowDialog();

            //--------------------------//

            //PlayLabelへ値を返す　Closeボタン押下ならそのまま値を返す
            if (questionEdition.isClose)
            {
                //Closeならnullを返す
                receiveTexts = null;
            }
            else
            {
                receiveTexts = questionEdition.ReturnValues;
            }

            questionEdition.Dispose();
            return receiveTexts;

        }

        //TextList用MiniForm　IDを受け取る　最初と最後に呼ばれる
        public string[] CategoryListUpdateMiniForm(string[] s)
        {
            //PlayLabelから受け取った引数をコンストラクタへ渡す
            questionEdition = new QuestionEdition(s)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            questionEdition.ShowDialog();

            //PlayLabelへ値を返す　Closeボタン押下ならそのまま値を返す
            if (questionEdition.isClose)
            {
                //Closeならnullを返す
                receiveTexts = null;
            }
            else
            {
                receiveTexts = questionEdition.ReturnValues;
            }

            questionEdition.Dispose();
            return receiveTexts;

        }
        //×ボタン押下時
        private void RowEdition_FormClosing(object sender, FormClosingEventArgs e)
        {
            //×ボタンの一回目以外は通さない
            if (!goSaveForm) return;
            goSaveForm = false;

            //saveするかしないかのブールを返してUpdateボタンかCloseボタンに振り分ける
            bool doSave = save.ShowSaveForm();

            if (doSave)
            {
                Updatebutton_Click(this, EventArgs.Empty);
            }
            else
            {
                CloseButton_Click(this, EventArgs.Empty);
            }
        }

        //キーイベント
        private void QuestionEdition_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter && e.Control) || (e.KeyCode == Keys.Space && e.Control))
            {
                Updatebutton_Click(this, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                CloseButton_Click(this, e);
            }
        }

    }
}
