using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaRegistr
{
    class Vsyakoe
    {
        //string connectionString = "SERVER=localhost;User Id=root;DATABASE=MY;PORT=3306;password=vilkova199820";
        //using (MySqlConnection connection = new MySqlConnection(connectionString))
        //{
        //    connection.Open();
        //    string query = @"CREATE TABLE `my`.`test`(
        //                    test1 DOUBLE(13,2),
        //                    test2 DOUBLE(13,2),
        //                    test3 DOUBLE(13,2),
        //                    test4 DOUBLE(13,2));";
        //    using (MySqlCommand cmd = new MySqlCommand(query, connection))
        //    {
        //        cmd.ExecuteNonQuery();
        //        string[] files = Directory.GetFiles(@"C:\Users\User\Desktop\Практика", "*.csv");

        //        foreach (string file in files)
        //        {
        //            query = @"LOAD DATA LOCAL INFILE '" + file + "' INTO TABLE `my`.`test` FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n'";
        //            using (MySqlCommand cmd1 = new MySqlCommand(query, connection))
        //            {
        //                cmd1.ExecuteNonQuery();
        //            }

        //        }

        //    }
        //}
        //  class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        string[] lines = File.ReadAllLines("Test.txt", Encoding.Default);
        //        FillDatabase(lines);
        //        Console.WriteLine("Operation complete!");
        //        Console.ReadLine();
        //    }

        //}



        //-------------------------------http://www.cyberforum.ru/ado-net/thread1466011.html----------------------------------//




        //importCSV(@"C:\Users\User\Desktop\Практика\Книга2.xlsx");

        //openFileDialog1.Filter = "CSV Files(*.csv)|*.csv";
        //if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
        //    return;
        //// получаем выбранный файл
        //string filename = openFileDialog1.FileName;
        //// читаем файл в строку

        //string Constr = @"SERVER=localhost;User Id=root;DATABASE=MY;PORT=3306;password=vilkova199820";
        //MySqlConnection con = new MySqlConnection(Constr);
        //MySqlCommand cmd = new MySqlCommand();
        //cmd.Connection = con;



        //try
        //{
        //    //-------------------------------ЗДЕСЬ НАДО СДЕЛАТЬ ВСТАВКУ ДАННЫХ В MYSQL--------------------------------------//

        //    string fileText = System.IO.File.ReadAllText(filename, Encoding.GetEncoding(1251));
        //    //cmd.CommandText = "insert into `my`.`data` values (fileText)";
        //    richTextBox1.Text = fileText;
        //    MessageBox.Show("Файл открыт");
        //}
        //catch(Exception ex) {
        //    MessageBox.Show("Ошибка: "+ex.Message);
        //}
    }
}
