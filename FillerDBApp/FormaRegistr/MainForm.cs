using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using BL;

namespace FormaRegistr
{

    public partial class Entrance : Form
    {

        //---------------------------САМАЯ ПЕРВАЯ ФОРМОЧКА АВТОРИЗАЦИИ----------------------------------//

        AutorizationService service;

        public Entrance()
        {
            service = new AutorizationService();
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //---------------------------КНОПОЧКА, ЧТОБЫ ВЫЙТИ ОТСЮДА УЖЕ НАКОНЕЦ----------------------------//

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //--------------------------------------КНОПОЧКА ВХОДА В САМУ ПРОГРАММУ--------------------------//

        private void Input_Click(object sender, EventArgs e)
        {
            bool result = false;
            try
            {
                result = service.Authorize(UserName.Text, UserPassword.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный логин или пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserName.Clear();
                UserPassword.Clear();
                result = false;
            }

            if (result)
            {
                this.Hide();
                FormChooser frm2 = new FormChooser(this);
                frm2.Show();
            }
        }

        private void Entrance_Load(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
