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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            HelpText();
            this.ShowDialog();
        }

        private void Help_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                case Keys.Enter:
                    Closebutton_Click(this, e);
                    break;
            }
        }
        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HelpText()
        {
            HelprichTextBox.Text = "▶使用方法・・「CategoryCreeate」ボタンから新規カテゴリーを作成＞CategoryMenuの「Addより問題を登録」＞カテゴリーの一覧より学習したいカテゴリーを選択＞ Runボタンを押してスタート" + Environment.NewLine+ Environment.NewLine +
               "「HOME」・・アプリケーションをリセットしてホーム画面へ戻ります。" + Environment.NewLine +
                "「CategoryCreate(C)」・・新規のカテゴリーを追加することができるボタン。（ショートカットキーC）" + Environment.NewLine +
                "「Late」・・カテゴリーリストをカテゴリーの作成された日付の新しい順に並び替えます。" + Environment.NewLine +
                "「Old」・・カテゴリーリストをカテゴリーの作成された日付の古い順に並び替えます。" + Environment.NewLine +
                "「ABC」・・カテゴリーリストをABC順に並び替えます。" + Environment.NewLine +
                "「Run」・・選択したカテゴリーを実行します。" + Environment.NewLine +
                "「Questions」・・出題問題数を設定します。例）デフォルトのQuestionsが5の場合は、新規出題5問、1日前～の復習5問、１週間前～の復習5問、１か月前～の復習5問の計20問が出題されます。尚、復習期間を満たさない事で出題問題数が不足する場合は、登録されている問題がランダムで出題されます。" + Environment.NewLine +
                "「Repeat」・・Questionsで設定した問題数を繰り返します。Repeat回数が１でQuestionsが5の場合は合計で40問に回答します。" + Environment.NewLine +
                "CategoryMenu「Add」・・問題を登録することができます。カテゴリーを新規で作成した場合は、まずこちらから問題を登録します。その後はCategoryEditからも問題を追加することが出来るようになります。FirstTextへは問題、SecondTextへは回答、Additionへは補足、AudioURLへは音声の再生先URL（右クリック＞リンクのアドレスをコピー）を登録します。" + Environment.NewLine +
                "CategoryMenu「Delete」・・カテゴリーを削除します。" + Environment.NewLine +
                "CategoryMenu「CategoryEdit」・・カテゴリーへ登録した問題の一覧を表示します。またここから問題の編集・削除・問題の追加をすることが出来ます。" + Environment.NewLine +
                "";

            //指定文字を太字にする
            string[] changeTexts = { "使用方法", "「HOME」", "「CategoryCreate(C)」", "「Late」" , "「Old」" , "「ABC」" , "「Run」" , "「Questions」", "「Repeat」" , "CategoryMenu「Add」" , "CategoryMenu「Delete」" , "CategoryMenu「CategoryEdit」" };
            foreach (string changeText in changeTexts)
            {
                TextForBold(HelprichTextBox, changeText);
            }
        }

        //太字メソッド
        public void TextForBold(RichTextBox rtb , string changeText)
        {
            //現在の選択状態を覚えておく
            int currentSelectionStart = rtb.SelectionStart;
            int currentSelectionLength = rtb.SelectionLength;

            int pos = 0;
            for (; ; )
            {
                pos = rtb.Find(changeText, pos, RichTextBoxFinds.None);
                if (pos < 0)
                {
                    break;
                }
                //太字にする
                rtb.SelectionFont = new Font(rtb.SelectionFont, FontStyle.Bold);
                pos++;
            }

            //選択状態を元に戻す
            rtb.Select(currentSelectionStart, currentSelectionLength);
        }

        private void HelprichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
