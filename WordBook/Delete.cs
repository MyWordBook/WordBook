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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
       
        //Yesボタン
        private void Yesbutton_Click(object sender, EventArgs e)
        {
            doDelete = true;
            this.Close();
        }

        //Noボタン
        private void Nobutton_Click(object sender, EventArgs e)
        {
            doDelete = false;
            this.Close();
        }
      

        //DeleteMiniForm　最初と最後に呼ばれる
        public static bool doDelete;
        public static bool DeleteMiniForm()
        {
            Delete delete = new Delete
            {
                StartPosition = FormStartPosition.CenterParent
            };
            delete.ShowDialog();
            //----------------------------//
            return Delete.doDelete;
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
