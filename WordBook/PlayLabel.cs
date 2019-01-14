using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SmallBasic.Library;

namespace WordBook
{
    public partial class PlayLabel : UserControl
    {
        //他クラスを参照
        DataCenter dc;
        QuestionEdition re;
        Ebbinghaus eb;

        //連続表示再生を防止
        bool canDisplay;
        public bool canPlay;
        private int QuestionIndex = 0;
        private int repeat;

        //復習テーブルへ登録するタイミングを通知
        static public event EventHandler AddSentenceFor_EbbinghausEvent = delegate { };

        public PlayLabel()
        {
            InitializeComponent();
            dc = new DataCenter();
            re = new QuestionEdition();
            eb = new Ebbinghaus();
        }
        //フォームのロード　
        private void PlayLabel_Load(object sender, EventArgs e)
        {
            DiscriptionText();
            this.ActiveControl = this.Startbutton;
        }
        //スタートボタン
        public void Startbutton_Click(object sender, EventArgs e)
        {
            //スタート時の表示フラグなど
            #region
            Answer.Visible = true;
            Nextbutton.Visible = true;
            EditCombo.Visible = true;
            Audiobutton.Visible = false;
            DiscriptiontextBox.Visible = false;
            SecondText.Visible = true;
            AdditionText.Visible = true;
            canDisplay = true;
            canPlay = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            SecondText.ResetText(); AdditionText.ResetText();
            Startbutton.Visible = false;
            this.ActiveControl = this.Answer;
            #endregion

            //Ebbinghausクラスから本日の出題分を取得
            eb.CreateQuestions(DicidedInformation.QuestionNumber, DicidedInformation.UsingTable);

            dc.Display(FirstText, eb.Quetions[QuestionIndex, 1]); 　//実行時、１問目のFirstSentenceを表示
            FirstText.Visible = true;
        }

        //Audioボタン
        public void Audiobutton_Click(object sender, EventArgs e)
        {
            Audiobutton.Enabled = false;
            Sound.PlayAndWait(eb.Quetions[QuestionIndex, 4]);
            //連続クリックに対応
            Application.DoEvents();
            Audiobutton.Enabled = true;
            Audiobutton.Focus();
        }

        //Answerボタン  SecondSentenceの表示とサウンド再生
        public void Answer_Click(object sender, EventArgs e)
        {
            if (canDisplay)
            {
                //テキストボックスへの表示
                dc.Display(SecondText, eb.Quetions[QuestionIndex, 2]);
                SecondText.Visible = true;
                dc.Display(AdditionText, eb.Quetions[QuestionIndex, 3]);
                AdditionText.Visible = true;
                canDisplay = false;

                //Audioを再生
                Sound.Play(eb.Quetions[QuestionIndex, 4]);
                Audiobutton.Enabled = true;

                //audioボタンの読み込み
                Audiobutton.Visible = true;
                Audiobutton.Focus();
                this.ActiveControl = this.Audiobutton;
            }
            this.Answer.Visible = false;
        }

        //Nextボタン  各パラメーターのリセット　表示クリア、新たなデータ取得・表示、ボタンの表示など
        public void Nextbutton_Click(object sender, EventArgs e)
        {
            Sound.PlayClickAndWait();　//クリック音
            FirstText.ResetText(); SecondText.ResetText(); AdditionText.ResetText(); //textboxリセット
            Audiobutton.Enabled = false;
            Audiobutton.Visible = false;
            Answer.Visible      = true;
            canDisplay          = true;
            this.ActiveControl  = this.Answer;

            //Nextボタン押下でQuestionIndexを進めて問題を次に進める
            int quetionsCounter = eb.Quetions.GetLength(0);　//本日出題数を取得
            QuestionIndex++;
            if (quetionsCounter > QuestionIndex)　//本日出題数を超えるまで問題を進める
            {
                dc.Display(FirstText, eb.Quetions[QuestionIndex, 1]);
            }
            else  //本日出題数上限に達するとCountをリセットして最初からスタート、リピート回数消化でMessageBox
            {
                QuestionIndex = 0;
                dc.Display(FirstText, eb.Quetions[QuestionIndex, 1]);
                repeat++;
                if (repeat > DicidedInformation.RepeatNumber)
                {
                    MessageBox.Show("本日の規定回数をクリアしました！");
                }
                else
                {
                    MessageBox.Show((repeat + 1) + "周目です");
                }
            }
            //本日出題をこなした場合は、復習テーブルへ登録
            if (DicidedInformation.QuestionNumber == QuestionIndex)
            {
                AddSentenceFor_EbbinghausEvent(this, EventArgs.Empty);　//イベント通知
            }
        }

        //Editコンボボックス
        private void EditCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択項目を取得
            var selectedItem = EditCombo.SelectedItem.ToString();

            switch (selectedItem)
            {
                //Edit選択の場合、現在表示問題の全項目をミニフォームへ送って変更したテキストを返してもらってデータセンターで登録
                case "Edit":
                    //現在のQuestionを送って変更したものを受け取る
                    string[] sendTexts = { eb.Quetions[QuestionIndex, 0], eb.Quetions[QuestionIndex, 1],
                                                     eb.Quetions[QuestionIndex, 2], eb.Quetions[QuestionIndex, 3], eb.Quetions[QuestionIndex, 4] };
                    string[] changedText = re.UpdateMiniForm(sendTexts);

                    //変更がなければbreak
                    if (sendTexts == changedText || changedText == null) break;

                    //変更をデータベースへ登録　引数（テーブルネーム、first,second,addition,audio, subid）
                    dc.EditRow(DicidedInformation.UsingTable, changedText[0], changedText[1], changedText[2], 
                                     changedText[3], int.Parse(eb.Quetions[QuestionIndex, 0]));

                    //テーブル名一覧を取得して、復習テーブルがあればそちらへも登録
                    List<string> tableList = dc.GetSortedTable("Late");
                    if (tableList.Contains(DicidedInformation.UsingTable_Ebbinghaus))
                        dc.EditRow(DicidedInformation.UsingTable_Ebbinghaus, changedText[0], changedText[1], changedText[2],
                                         changedText[3], int.Parse(eb.Quetions[QuestionIndex, 0]));

                    //PlayLabelのテキストボックスへも反映
                    Sound.PlayClick();
                    FirstText.ResetText(); SecondText.ResetText(); AdditionText.ResetText();
                    dc.Display(FirstText, changedText[0]);
                    dc.Display(SecondText, changedText[1]);
                    dc.Display(AdditionText, changedText[2]);
                    MessageBox.Show("変更が完了しました！\n次回学習から反映されます。");
                    break;

                //Delete選択の場合、現在表示されていた問題を削除する
                case "Delete":
                    bool doDelete = Delete.DeleteMiniForm();
                    if (doDelete)
                    {
                        //該当問題のidを取得して登録テーブル、出題テーブルの両方から削除
                        dc.DeleteRow(DicidedInformation.UsingTable, int.Parse(eb.Quetions[QuestionIndex, 0]));
                        dc.DeleteRow(DicidedInformation.UsingTable_Ebbinghaus, int.Parse(eb.Quetions[QuestionIndex, 0]));
                        //テキストボックスをリセット
                        FirstText.ResetText(); SecondText.ResetText(); AdditionText.ResetText();
                    }
                    break;
            }
        }

        //Editボタンクリック時にフォーカスを調整
        private void EditCombo_Click(object sender, EventArgs e)
        {
            EditCombo.Focus();
        }

        //フォーカスの移動
        private void Startbutton_LostFocus(object sender, EventArgs e)
        {
            if (this.Visible) Answer.Focus();
        }
        private void Audiobutton_LostFocus(object sender, EventArgs e)
        {
            //現在アクティブなコントロールを取得する
            string nowFocus = this.ActiveControl.Name.ToString();
            if (nowFocus == "Nextbutton" || nowFocus == "Startbutton" || nowFocus == "PlayLabel" || nowFocus == "AdditionText")
            {
                Audiobutton.Focus();
            }
        }

        //キーイベント
        private void Audiobutton_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S:
                case Keys.A:
                    Nextbutton_Click(this, e);
                    break;
                case Keys.Enter:
                case Keys.Space:
                    Audiobutton_Click(this, e);
                    break;
            }
        }
        private void DiscriptiontextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) Startbutton_Click(this, e);
        }

        //使用説明
        private void DiscriptionText()
        {
            DiscriptiontextBox.Text = string.Format(
                "▶登録した問題はエビングハウスの忘却曲線に基づいて出題されます。問題が出題されたら声に出して回答をします。" + Environment.NewLine +
                "▶推奨の学習サイトはTALKENGLISH.com(https://www.talkenglish.com/)です。デフォルトで登録してあるカテゴリーはこちらのサイトのものです。練習をする内容を一通り把握した後に練習に移ります。また、覚えたいSentenceを登録したい場合は、www.ManyThings.org（http://www.manythings.org/o/）というサイトに豊富な例文と音声があるので、このでサイト内検索をするとほとんどの場合登録に困らないでしょう。" + Environment.NewLine +
                "▶デフォルト出題数（Questions 5 + Repeat 1)の場合の一般的な所要時間は、問題についての多少の調べ事を行う時間を含めておおよそ１５分～30分程度です。それぞれの学習時間に応じてここの部分を調整します。その日のうちに同じ問題を繰り返した方が良い為、Repeatは１回以上に設定してQuestionsの方で時間を調節します。" + Environment.NewLine +
                "▶登録した問題はいつでも削除することができます。同日を除き３～４回程度連続で３秒以内に回答ができ、発音にも問題がなければ同文法の問題の入れ替えなどをして、学習の新陳代謝を図れるようになっています。" + Environment.NewLine +
                "▶問題は繰り返し出題されます。推奨の学習方法は１問に時間をかけ過ぎず、同じ問題を何度も繰り返す方法です。目安としては出題後３秒以内に回答し、回答が出てこない＆誤答の場合は音声を数回繰り返し聞いて、その後目を閉じて回答ができれば次に進みます。しかし「思い出す作業」が記憶の定着に大きく関係する為、このプロセスを飛ばさないようにします。" + Environment.NewLine +
                "▶学習画面ではボタンクリックの他、一部機能をキーボードで操作することもできます。学習画面では１度目のEnter又はSpaceキーでAnswerボタン（音声の再生と回答の表示）２度目以降のEnter又はSpaceキーでAudioボタン（音声の再生）、Sボタンで次の問題に進みます。マウス操作をすることなく学習ができ、学習に集中できるようになっています。");
        }
    }
}
