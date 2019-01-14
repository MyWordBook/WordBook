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
    public partial class Save : Form
    {
        Save save;
        public bool doSave;

        public Save()
        {
            InitializeComponent();
        }
        //Saveボタン
        public void Savebutton_Click(object sender, EventArgs e)
        {
            this.doSave = true;
            this.Close();
        }
        //Noボタン
        public void Nobutton_Click(object sender, EventArgs e)
        {
            this.doSave = false;
            this.Close();
        }
        //最初と最後に呼ばれる
        public bool ShowSaveForm()
        {
            save = new Save
            {
                StartPosition = FormStartPosition.CenterParent
            };
            save.ShowDialog();
            //----------------------------//
            return save.doSave;
        }

        private void Save_Load(object sender, EventArgs e)
        {

        }
        //キーイベント
        private void Save_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    Nobutton_Click(this, e);
                    break;
                case Keys.Enter:
                case Keys.Space:
                    Savebutton_Click(this, e);
                    break;
            }
        }
    }
}
