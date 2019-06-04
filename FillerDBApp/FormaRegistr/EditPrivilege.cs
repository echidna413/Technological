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
    public partial class EditPrivilege : Form
    {
        public EditPrivilege()
        {
            InitializeComponent();
        }
        Form formtoopen;

        public EditPrivilege(ControlUsers cu1)
        {
            InitializeComponent();
            formtoopen = cu1;
            // s.BackColor = Color.Pink;
        }
        private void EditPrivilege_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        //-------------------------------------------ФУНКЦИЯ ДЛЯ ИЗМЕНЕНИЯ РОЛИ ПОЛЬЗОВАТЕЛЯ--------------------//

        private void ChangeRole(string login, string role)
        {
            if (role == "" || login == "")
            {
                MessageBox.Show("Введите данные!");

            }
            else
            {
                //-----------------------РОЛИ:админ, пользователь, отстранён----------------------//
                if (role == "admin" || role == "user" || role == "dismissed")
                {
                    string Connect = @"SERVER=localhost;User Id=root;DATABASE=MY;PORT=3306;password=vilkova199820";
                    MySqlConnection myConnection = new MySqlConnection(Connect);
                    using (myConnection)
                    {
                        var addUserCmd = new MySqlCommand("UPDATE `my`.`user` SET role = @Role WHERE username = @Login", myConnection);
                        addUserCmd.Parameters.AddWithValue("@Login", login);
                        addUserCmd.Parameters.AddWithValue("@Role", role);
                        try
                        {
                            myConnection.Open();
                            addUserCmd.ExecuteNonQuery();
                            MessageBox.Show("Роль пользователя успешно изменена!");
                            UserName.Clear();
                            UserRole.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }
                    myConnection.Close();
                   
                }
                else
                {
                    MessageBox.Show(role);
                    MessageBox.Show("Несуществующая роль! Выберите между: admin или user");

                }
            }
        }

        //--------------------------------------КНОПКА РЕДАКТИРОВАНИЯ РОЛЕЙ--------------------------------------//

        private void EditRole_Click(object sender, EventArgs e)
        {
            ChangeRole(UserName.Text, UserRole.Text);
        }
    }
}
