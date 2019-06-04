using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormaRegistr
{
    public partial class FormChooser : Form
    {
        

        //--------------------------------------ФОРМА ВЫБОРА ДАЛЬНЕЙШИХ ДЕЙСТВИЙ (ЗАВИСИТ ОТ РОЛИ)--------------------------//

        public FormChooser()
        {
            InitializeComponent();
           
        }
        Form formtoopen;
        public FormChooser(Entrance f)
        {
            InitializeComponent();
            formtoopen = f;
           // f.BackColor = Color.Blue;
        }
        //--------------------------------------ПЕРЕХОД В НАСТРОЙКИ(ДЛЯ АДМИНА ТОЛЬКО)--------------------------//

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings set = new Settings(this);
            set.Show();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Data.Value != "admin")
            {
                Settings.Hide();
            }
        }

        //--------------------------------------ПЕРЕХОД В ЭКСПОРТ/ИМПОРТ ФАЙЛА В БД(.csv)--------------------------//

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportExport ix = new ImportExport(this);
            ix.Show();
        }

        //-------------------------ПЕРЕХОД В ФОРМУ СОРТИРОВКИ ДАННЫХ ДЛЯ ВЫВОДА В ГЛАВНУЮ ТАБЛИЦУ-------------------//

        private void Vvod_dannyh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKodOborudov frm3= new FormKodOborudov(this);
            frm3.Show();
        }

        //--------------------------------------НАЗАД В ГЛАВНУЮ ФОРМОЧКУ ВХОДА--------------------------//
        //--------------------------------------ТУТ КАКОЕ ТО ИСКЛЮЧЕНИЕ---------------------------------//
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();          
            formtoopen.Show();
         
        }
    }
}
