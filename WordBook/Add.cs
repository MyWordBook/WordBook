using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SmallBasic.Library;


namespace WordBook
{
    public partial class Add : Form
    {
        DataCenter dc;
        private string Table;

        public Add(string table)
        {
            InitializeComponent();
            dc = new DataCenter();
            this.Table = table;

            this.StartPosition = FormStartPosition.CenterParent;
            ShowDialog();
        }
        //ロード
        private void Add_Load(object sender, EventArgs e)
        {
            firstTextBox.Focus();
        }
        //Addボタン
        private void Addbutton_Click(object sender, EventArgs e)
        {
            Sound.PlayClickAndWait(); //クリック音

            //テキストボックスへの入力をデータベースへ登録
            string firstText = firstTextBox.Text;
            string secondText = secondTextBox.Text;
            string addiText = AddiTextBox.Text;
            string soundUrl = soundUrlTextBox.Text;
            dc.DataInsert(Table, firstText, secondText, addiText, soundUrl);

            //テキストボックスをすべてクリア
            firstTextBox.ResetText(); secondTextBox.ResetText(); AddiTextBox.ResetText(); soundUrlTextBox.ResetText();

            this.Close();
        }
            //Closeボタン
            private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //キーイベント
        private void Add_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter && e.Control) || (e.KeyCode == Keys.Space && e.Control))
            {
                Addbutton_Click(this, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                CloseButton_Click(this, e);
            }
        }
   
    }
}
