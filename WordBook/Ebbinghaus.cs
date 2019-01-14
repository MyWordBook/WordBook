using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBook {
    /// <summary>
    ///  新規の出題処理、復習テーブルへ日付をつけて登録、過去出題を取得して本日出題するすべての問題を結合
    /// </summary>
    class Ebbinghaus {
        DataCenter dc;
        public string[,] Quetions { get; private set; }　//出題する問題をすべて入れる

        public Ebbinghaus() {
            dc = new DataCenter();
        }

        public void CreateQuestions(int num, string tableName)　
        {
            //新規出題分の変数
            var todayQuestions = new string[num, 5];

            //テーブル名一覧を取得して、復習テーブル（"_Ebbinghaus"の名前の入ったテーブル）が作成済みかどうか調べて、無ければ作成する
            List<string> tableList = dc.GetSortedTable("Late");

            //復習テーブル未作成の場合　
            if (!tableList.Contains(tableName + "_Ebbinghaus"))
            {
                //復習テーブル作成
                dc.CreateNewTable(tableName + "_Ebbinghaus");
                //numの数だけ問題を取得
                todayQuestions = dc.GetRandomRow(num, tableName);
                //出題分は復習テーブルへ登録
                RegistrateTo_Ebbinghaus(tableName, todayQuestions, todayQuestions.GetLength(0));
            }
            //復習テーブルができている場合
            else
            {
                //登録IDを比較して、未出題のものを探して優先的に出題する
                List<int> IdList = dc.GetIdList(tableName);  　　　　　　　　　　　　　　　　//登録テーブルからIdを調べる
                List<int> IdList_Ebbinghaus = dc.GetIdList(tableName + "_Ebbinghaus"); ;  //復習テーブルからSubIdを調べる
                //未出題Idを取得
                var UnuseId = UnuseIdGetter(IdList, IdList_Ebbinghaus);
                //リストの中身をランダムに並び替え
                UnuseId = UnuseId.OrderBy(i => Guid.NewGuid()).ToList();

                //出題するために取得した問題数をカウント
                var numberCounter = 0;
                //未出題のものをnumの数だけtodayへ入れる 
                for (int i = 0; i < num; i++)
                {
                    //未出題の問題がnumの数だけ、足りない||なければbreak
                    if (numberCounter >= UnuseId.Count || UnuseId.Count == 0)
                        break;

                    string[] today_unuseQuestions = dc.GetRow(tableName, UnuseId[i]);
                    todayQuestions[numberCounter, 0] = today_unuseQuestions[0].ToString();
                    todayQuestions[numberCounter, 1] = today_unuseQuestions[1].ToString();
                    todayQuestions[numberCounter, 2] = today_unuseQuestions[2].ToString();
                    todayQuestions[numberCounter, 3] = today_unuseQuestions[3].ToString();
                    todayQuestions[numberCounter, 4] = today_unuseQuestions[4].ToString();

                    numberCounter++;
                }

                //新規出題分を学習したら通知を受け復習テーブルへ登録。また復習問題を偏らせない為、一日の登録数をnum個と制限する
                PlayLabel.AddSentenceFor_EbbinghausEvent += delegate (object sender, EventArgs e)
                {
                    //今日の日付で出題テーブルへ登録されている数をカウント
                    int registrationCount = dc.TodayRegistrationCount(tableName + "_Ebbinghaus");
                    //今日の日付での登録数がnumより少ない場合は復習テーブルへ登録する
                    RegistrateTo_Ebbinghaus(tableName, todayQuestions, num - registrationCount);
                };

                //未出題の問題数が足りなければ不足分をランダムで取得
                int shortage = num - numberCounter;
                int fill = 0;
                for (; numberCounter < shortage; numberCounter++)
                {
                    string[,] today_random = dc.GetRandomRow(shortage, tableName);
                    
                    todayQuestions[numberCounter, 0] = today_random[fill, 0];
                    todayQuestions[numberCounter, 1] = today_random[fill, 1];
                    todayQuestions[numberCounter, 2] = today_random[fill, 2];
                    todayQuestions[numberCounter, 3] = today_random[fill, 3];
                    todayQuestions[numberCounter, 4] = today_random[fill, 4];
                    fill++;
                }
            }

            //「tableName + "_Ebbinghaus"」から出題１日後の問題を降順で取得
            string[,] oneDayPast = dc.GetPastQuestions(tableName, num, 1);
            //「tableName + "_Ebbinghaus"」から出題一週間後の問題を降順で取得
            string[,] oneWeekPast = dc.GetPastQuestions(tableName, num, 7);
            //「tableName + "_Ebbinghaus"」から出題一か月後の問題を降順で取得
            string[,] oneMonthPast = dc.GetPastQuestions(tableName, num, 30);

            //出題表示の為に本日出題分二次元配列ををすべて連結させる
            int QuestionsNumber = todayQuestions.GetLength(0) + oneWeekPast.GetLength(0) 
                                               + oneWeekPast.GetLength(0) + oneWeekPast.GetLength(0);

            var merged = new string[QuestionsNumber, 5];
            Array.Copy(todayQuestions, 0, merged, 0, todayQuestions.Length);
            Array.Copy(oneDayPast, 0, merged, todayQuestions.Length, oneDayPast.Length);
            Array.Copy(oneWeekPast, 0, merged, todayQuestions.Length + oneDayPast.Length, oneWeekPast.Length);
            Array.Copy(oneMonthPast, 0, merged, todayQuestions.Length + oneDayPast.Length + oneWeekPast.Length, oneMonthPast.Length);

            //Quetions へ代入してPlayLabelで使用
            Quetions = merged;
        }

        //未出題Idを調べるメソッド
        public List<int> UnuseIdGetter(List<int> id, List<int> subId) {
            foreach (var sub in subId)
            {
                id.Remove(sub);
            }
            return id;
        }
        //復習テーブルへの登録メソッド
        public void RegistrateTo_Ebbinghaus(string tableName, string[,] question, int rowCount) {
            for (int i = 0; i < rowCount; i++)
            {
                dc.AddRowFor_Ebbinghaus(tableName + "_Ebbinghaus", question[i, 0], question[i, 1]
                                                         ,question[i, 2], question[i, 3], question[i, 4]);
            }
        }

    }
}
