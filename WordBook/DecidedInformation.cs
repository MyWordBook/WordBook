using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBook
{
    //情報クラス
    public class DicidedInformation
    {
        static public int QuestionNumber { get; set; }  //基本出題数

        static public int RepeatNumber { get; set; }  //繰り返し回数

        static public string UsingTable { get; set; }  //使用カテゴリー

        static public string UsingTable_Ebbinghaus => UsingTable + "_Ebbinghaus";   //復習テーブル

    }
}
