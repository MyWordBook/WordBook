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
using System.Collections;

namespace WordBook {
    //データベース
    public class DataCenter {
        private SqlConnection connection;

        public DataCenter() {
            // WordBookデータベースの接続文字列
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\repos\project\WordBook\WordBook\WordBook.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);

        }

        //指定テーブルでランダムでnum行のデータを取り出す　　コマンドをメソッド化できない？tryの中身だけ
        public string[,] GetRandomRow(int num, string tableName) {
            connection.Open();
            try {
                string sqlstr = string.Format("select top({0}) * from {1} order by NEWID()", num, tableName);
                SqlCommand com = new SqlCommand(sqlstr, connection);
                SqlDataReader sdr = com.ExecuteReader();
                var rows = new string[num, 5];
                int i = 0;
                //列数の５で区切って配列へ入れていく
                while (sdr.Read() == true) {
                    rows[i, 0] = sdr["Id"].ToString();
                    rows[i, 1] = (string)(DBNull.Value.Equals(sdr["FirstSentence"]) ? null : sdr["FirstSentence"]);
                    rows[i, 2] = (string)(DBNull.Value.Equals(sdr["SecondSentence"]) ? null : sdr["SecondSentence"]);
                    rows[i, 3] = (string)(DBNull.Value.Equals(sdr["Addition"]) ? null : sdr["Addition"]);
                    rows[i, 4] = (string)(DBNull.Value.Equals(sdr["AudioLink"]) ? null : sdr["AudioLink"]);
                    i++;
                }
                return rows;
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();

            }
        }
        //指定テーブルのIDをすべて取り出す　
        public List<int> GetIdList(string tableName) {
            connection.Open();
            string sqlstr;
            var IdList = new List<int>();
            try {  //テーブル名に "_Ebbinghaus"が付いていたらSubIdを取り出す
                if (tableName.Contains("_Ebbinghaus")) {
                    sqlstr = string.Format("select [SubId] from {0} ", tableName);
                    SqlCommand com = new SqlCommand(sqlstr, connection);
                    SqlDataReader sdr = com.ExecuteReader();

                    while (sdr.Read() == true) {
                        var id = sdr["SubId"].ToString();
                        IdList.Add(Convert.ToInt32(id));
                    }
                } else //登録テーブル名ならIdを取り出す
                    {
                    sqlstr = string.Format("select [Id] from {0} ", tableName);
                    SqlCommand com = new SqlCommand(sqlstr, connection);
                    SqlDataReader sdr = com.ExecuteReader();

                    while (sdr.Read() == true) {
                        var id = sdr["Id"].ToString();
                        IdList.Add(Convert.ToInt32(id));
                    }
                }
                return IdList;
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //指定出題テーブルの登録日をすべて取り出す
        public int TodayRegistrationCount(string tableName) {
            connection.Open();
            string sqlstr;
            //本日の日付を取得
            var today = DateTime.Now.ToShortDateString();

            try {
                sqlstr = string.Format("select [InsertDateTime] from {0} ", tableName);
                SqlCommand com = new SqlCommand(sqlstr, connection);
                SqlDataReader sdr = com.ExecuteReader();

                int TodayCount = 0;
                while (sdr.Read() == true) {
                    if (today == sdr.GetDateTime(0).ToShortDateString()) TodayCount++;
                }
                return TodayCount;
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //出題日よりhowLong日経過後の行をnum行取得
        public string[,] GetPastQuestions(string tableName, int num, int howLong) {
            connection.Open();
            try {
                //今日の日付からhowLong日差し引く
                var compareDay = DateTime.Now.AddDays(-howLong).ToShortDateString(); ;
                string sqlstr = string.Format("select  [SubId] , [FirstSentence] , [SecondSentence] , [Addition] , [AudioLink]  " +
                                                        " from {0}" +
                                                        " where  InsertDateTime < CONVERT(DATETIME,'{1}')  " +
                                                        "ORDER BY InsertDateTime DESC",
                                                        tableName + "_Ebbinghaus", compareDay);

                SqlCommand com = new SqlCommand(sqlstr, connection);
                SqlDataReader sdr = com.ExecuteReader();

                //１行の列数を入れ終わったら i++ して行を変えて配列へ入れていく
               var rows = new string[num, 5];
                int i = 0;
                while (sdr.Read() == true) {
                    rows[i, 0] = (string)(DBNull.Value.Equals(sdr["SubId"]) ? null : sdr["SubId"]);
                    rows[i, 1] = (string)(DBNull.Value.Equals(sdr["FirstSentence"]) ? null : sdr["FirstSentence"]);
                    rows[i, 2] = (string)(DBNull.Value.Equals(sdr["SecondSentence"]) ? null : sdr["SecondSentence"]);
                    rows[i, 3] = (string)(DBNull.Value.Equals(sdr["Addition"]) ? null : sdr["Addition"]);
                    rows[i, 4] = (string)(DBNull.Value.Equals(sdr["AudioLink"]) ? null : sdr["AudioLink"]);
                    i++;
                    if (i == num) return rows; //指定問題数をすべて取り出せれば Return
                }
                connection.Close();

                //条件に合う出題数に不足があった場合はランダムで出題数を補う
                int shortage = num - i;
                string[,] coverRows = GetRandomRow(shortage, tableName);
                //受け取った二次元配列を先入れ先出のリストへ一旦入れる
                Queue<string> coverQuestions = new Queue<string>();
                for (int n = 0; n < coverRows.GetLength(0); n++) {
                    for (int m = 0; m < coverRows.GetLength(1); m++) {
                        coverQuestions.Enqueue(coverRows[n, m]);
                    }
                }
                //先ほどのrowsの続きへ５要素ワンセットで二次元配列へ加えていく
                for (int j = 0; j < shortage; j++) {
                    for (int k = 0; k < 5; k++) {
                        rows[i + j, k] = coverQuestions.Dequeue();
                    }
                }
                return rows;
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //指定テーブル・IDで１行のすべての項目を取り出す
        public string[] GetRow(string tableName, int id) {
            connection.Open();
            try {
                string sqlstr = string.Format("select * from {0} where [Id] = {1}", tableName, id);
                SqlCommand com = new SqlCommand(sqlstr, connection);
                SqlDataReader sdr = com.ExecuteReader();
                var row = new string[5];

                while (sdr.Read() == true) {
                    row[0] = sdr["Id"].ToString();
                    row[1] = (string)(DBNull.Value.Equals(sdr["FirstSentence"]) ? null : sdr["FirstSentence"]);
                    row[2] = (string)(DBNull.Value.Equals(sdr["SecondSentence"]) ? null : sdr["SecondSentence"]);
                    row[3] = (string)(DBNull.Value.Equals(sdr["Addition"]) ? null : sdr["Addition"]);
                    row[4] = (string)(DBNull.Value.Equals(sdr["AudioLink"]) ? null : sdr["AudioLink"]);

                }
                return row;
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //テーブル名とIDでFirstSentenceを取り出す
        private string firstSentenceForList;
        public string FirstSentenceForListDisplay(string tableName, int idNumber) {
            connection.Open();
            try {
                string sqlstr = string.Format("select [FirstSentence] from {0} where [Id] = {1}", tableName, idNumber);
                SqlCommand com = new SqlCommand(sqlstr, connection);
                SqlDataReader sdr = com.ExecuteReader();

                while (sdr.Read() == true) {
                    firstSentenceForList = (string)(DBNull.Value.Equals(sdr["FirstSentence"]) ? null : sdr["FirstSentence"]);
                }
                return firstSentenceForList;
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }

        }
        //テーブル名一覧を取り出す
        /// <summary>
        /// type name={"Old","Late","ABC"}
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<string> GetSortedTable(string type) {
            connection.Open();
            try {
                string sqlstr;
                if (type == "Late") {
                    sqlstr = " select * from sys.objects where type = 'U'　ORDER BY modify_date desc ;";
                } else if (type == "Old") {
                    sqlstr = " select * from sys.objects where type = 'U'　ORDER BY  modify_date asc;";
                } else {
                    sqlstr = " select * from sys.objects where type = 'U';";
                }

                SqlCommand com = new SqlCommand(sqlstr, connection);
                SqlDataReader sdr = com.ExecuteReader();

                var tablList = new List<string>();
                while (sdr.Read() == true) {
                    tablList.Add(sdr.GetString(0));
                }
                return tablList;

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;

            } finally {
                connection.Close();
            }
        }
        //テーブルにデータ(Id)があるかチェック
        public bool HasTableData(string tableName) {
            connection.Open();
            try {
                var sqlstr = string.Format(" select * from {0}", tableName);
                SqlCommand com = new SqlCommand(sqlstr, connection);
                // SQLクエリの結果を読み出すSqlDataReader オブジェクトを取得
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.HasRows) {
                    return true;
                } else {
                    return false;
                }
            } finally {
                connection.Close();

            }
        }
        //データベースへの登録
        public void DataInsert(string tableName, string first, string second, string addition, string audi) {
            // データベースの接続開始
            connection.Open();
            try {
                string sqlstr = @"INSERT INTO " + @tableName + "(FirstSentence, SecondSentence,Addition,AudioLink) VALUES (@first, @second, @addition ,@audi)";
                SqlCommand command = new SqlCommand(sqlstr, connection);
                //メソッドの引数を受け取ってデータベースへ登録
                command.Parameters.Add(new SqlParameter("@tableName", tableName));
                command.Parameters.Add(new SqlParameter("@first", first));
                command.Parameters.Add(new SqlParameter("@second", second));
                command.Parameters.Add(new SqlParameter("@addition", addition));
                command.Parameters.Add(new SqlParameter("@audi", audi));
                // SQLの実行
                command.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                // データベースの接続終了
                connection.Close();

            }
        }
        //データベースの更新 引数からとった新しい値を入れる 　　
        public void EditRow(string tableName, string first, string second, string addi, string audi, int id) {
            SqlCommand command = new System.Data.SqlClient.SqlCommand();
            connection.Open();
            try {
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                //登録テーブルを変更する（出題テーブルが更新される場合も更新される
                command.CommandText = "UPDATE " + @tableName + "  SET [FirstSentence] = @FirstSentence,   [SecondSentence] = @SecondSentence, [Addition]  = @Addition,[AudioLink] = @AudioLink WHERE  [Id] = @Id";

                //出題テーブルを更新する
                if (tableName.Contains("_Ebbinghaus")) {
                    //該当SubId番号の各列の値を変更する
                    command.CommandText = "UPDATE " + @tableName + "  SET [FirstSentence] = @FirstSentence,   [SecondSentence] = @SecondSentence, [Addition]  = @Addition,[AudioLink] = @AudioLink WHERE  [SubId] = @Id";
                }

                command.Parameters.AddWithValue("@tableName", tableName);
                command.Parameters.AddWithValue("@FirstSentence", first);
                command.Parameters.AddWithValue("@SecondSentence", second);
                command.Parameters.AddWithValue("@Addition", addi);
                command.Parameters.AddWithValue("@AudioLink", audi);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //出題データベースへ加える(_Ebbinghaus)
        public void AddRowFor_Ebbinghaus(string tableName, string id, string first, string second, string addi, string audi) {
            SqlCommand command = new System.Data.SqlClient.SqlCommand();
            connection.Open();
            try {
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                string today = DateTime.Now.ToString();
                //SubIdに出題元データベースの主キーId番号を付ける、現在の日付を入れる
                command.CommandText = @"INSERT INTO " + @tableName + "(FirstSentence, SecondSentence,Addition,AudioLink,SubId,InsertDateTime) VALUES (@FirstSentence, @SecondSentence, @Addition ,@AudioLink,@Id, CONVERT( DATETIME ,@dtToday))";

                command.Parameters.AddWithValue("@tableName", tableName);
                command.Parameters.AddWithValue("@FirstSentence", first);
                command.Parameters.AddWithValue("@SecondSentence", second);
                command.Parameters.AddWithValue("@Addition", addi);
                command.Parameters.AddWithValue("@AudioLink", audi);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@dtToday", today);

                command.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //行を削除
        public void DeleteRow(string tableName, int id) {
            SqlCommand command = new System.Data.SqlClient.SqlCommand();
            connection.Open();
            try {
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                //表示時に取り出した主キーId番号の行を削除する
                command.CommandText = string.Format("DELETE {0} WHERE [Id] = @Id", tableName);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }

        }
        //テーブル名の変更  未実装
        //public void RenameTable(string nowName, string changedName)
        //{
        //    SqlCommand command = new System.Data.SqlClient.SqlCommand();

        //    connection.Open();
        //    try
        //    {
        //        command.Connection = connection;
        //        command.CommandType = CommandType.Text;

        //        command.CommandText = string.Format("EXEC sp_rename '{0}','{1}'", nowName, changedName);
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception exception)
        //    {
        //        Console.WriteLine(exception.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        //新規テーブルを作成
        public void CreateNewTable(string name) {
            SqlCommand command = new System.Data.SqlClient.SqlCommand();

            connection.Open();
            try {
                if (name.Contains("_Ebbinghaus")) //_Ebbinghausがつくテーブルには日付の列を加える
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "CREATE TABLE " + @name + "([Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, [FirstSentence] NVARCHAR (MAX),[SecondSentence] NVARCHAR (MAX),[Addition] NVARCHAR (MAX), [AudioLink] NVARCHAR (MAX),[SubId]  NVARCHAR (50),  [InsertDateTime] DATE) ";

                    command.Parameters.AddWithValue("@name", name);
                } else {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "CREATE TABLE " + @name + " ([Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, [FirstSentence] NVARCHAR (MAX),[SecondSentence] NVARCHAR (MAX),[Addition] NVARCHAR (MAX), [AudioLink] NVARCHAR (MAX)) ";
                    command.Parameters.AddWithValue("@name", name);
                }
                command.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //テーブルを削除
        public void DeleteTable(string tableName) {
            SqlCommand command = new System.Data.SqlClient.SqlCommand();

            connection.Open();
            try {
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = string.Format("DROP TABLE IF EXISTS  {0} ", tableName);
                command.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw;
            } finally {
                connection.Close();
            }
        }
        //ラベル表示メソッド
        public void Display(TextBox textBox, string str) {
            if (str != null)
                textBox.Text += str;
        }
    }
}
