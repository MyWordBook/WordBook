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
    public partial class Rename : Form
    {
        private string changedText;
        private bool Back;
        private bool toSave;

        private string receiveText;

        public Rename()
        {
            InitializeComponent();

        }

        private void Rename_Load(object sender, EventArgs e)
        {
            ChangeNametextBox.Focus();
            receiveText = null;
            toSave = false;
        }
        //最初と最後に呼ばれる
        public string RenameMiniForm()
        {
            Rename reName = new Rename();
            reName.ShowDialog();


            //----------------------------//
            if (!reName.Back) receiveText = reName.changedText;

            reName.Dispose();
            return receiveText;
        }
        //doボタン
        private void Dobutton_Click(object sender, EventArgs e)
        {
            var inputText = ChangeNametextBox.Text;
            inputText= Regex.Replace(inputText, @"\s", "");

            //先頭の文字が
            if (!Regex.IsMatch(inputText, @"^[a-zA-Z]") )
            {
                MessageBox.Show("Input is incorrect.");
                ChangeNametextBox.ResetText();
                ChangeNametextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter something");
                ChangeNametextBox.Focus();
                return;
            }
            else
            {
                changedText = inputText;

                Back = false;
                toSave = true;
                this.Close();
            }
            
        }
        //Backボタン
        private void Backbutton_Click(object sender, EventArgs e)
        {
            Back = true;
            toSave = false;
            this.Close();
        }
        //×ボタン
        private void Rename_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toSave) return;

            Back = true;
        }

    
    }
}
