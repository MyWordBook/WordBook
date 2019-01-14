using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBook
{
    public partial class CreateCategory : Form
    {
        private string name;
        public CreateCategory()
        {
            InitializeComponent();
        }
        //ロード
        private void CreateEdition_Load(object sender, EventArgs e)
        {
            NameTextBox.Focus();
        }
        //最初と最後に呼ばれる
        public static string CreateMiniForm()
        {
            CreateCategory createEdition = new CreateCategory
            {
                StartPosition = FormStartPosition.CenterParent
            };
            createEdition.ShowDialog();
            //----------------------------//
            return createEdition.name;
        }
        //Createボタン
        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create();
        }
               
        //Cancelボタン
        private void Close_Click(object sender, EventArgs e)
        {
            name = null;
            this.Close();
        }
        //Create時の処理
        private void Create()
        {
            var inputText = NameTextBox.Text;
            inputText = Regex.Replace(inputText, @"\s", "");
            //先頭の文字チェック
            if (!Regex.IsMatch(inputText, @"^[a-zA-Z]"))
            {
                MessageBox.Show("Input is incorrect.");
                NameTextBox.ResetText();
                NameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter something");
                NameTextBox.Focus();
                return;
            }
            else
            {
                name = inputText;
                this.Close();
            }
        }
        //キーイベント
        private void CreateCategory_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    Close_Click(this, e);
                    break;
                case Keys.Enter:
                case Keys.Space:
                    CreateButton_Click(this, e);
                    break;
            }
        }
    }
}
