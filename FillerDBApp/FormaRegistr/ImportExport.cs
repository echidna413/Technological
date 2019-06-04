using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Common;
using MySql.Data.MySqlClient;

namespace FormaRegistr
{
    public partial class ImportExport : Form
    {
        private LogHelper logimport = new LogHelper();
        private ImportService _import;
        //---------------------------ФОРМА ИМПОРТА И ЭСКПОРТА--------------------------//

        public ImportExport()
        {
            InitializeComponent();
            Import.Click += Import_Click;
            _import = new ImportService();

        }
        Form formtoopen;
        public ImportExport(FormChooser fc2)
        {
            InitializeComponent();
            formtoopen = fc2;
            _import = new ImportService();
        }
        //---------------------------КНОПКА НА ИМПОРТ--------------------------//

        private void Import_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files(*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            MessageBox.Show(filename);

            //------------------------------------------Можно ли вставлять один и тот же файл и нужно ли это проверять?------------------// 
            //------------------------------------------загружать в папку темп, потом проверку всех строк-------------------------------//
            //-----------------------------------------проверка на дублирование--------------------------------------------------------//

            try
            {
                string[] lines = File.ReadAllLines(filename, Encoding.Default);
                this._import.FillDatabase(lines);

                logimport.LogString(DbEvent.ImportData, logimport.ImportNaming(filename));
                MessageBox.Show("Данные из файла: " + filename + " успешно вставлены в базу данных!");
               // MessageBox.Show("good");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        //-----------------------------ФУНКЦИЯ ДЛЯ ДОБАВЛЕНИЯ ДАННЫХ В ТАБЛИЦУ MYSQL----------------------------------//

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }



        //---------------------------КНОПКА НА ЭКСПОРТ------------------------//

        private void Export_Click(object sender, EventArgs e)
        {

        }

        private void ImportExport_Load(object sender, EventArgs e)
        {

        }
        
     
    }
}
