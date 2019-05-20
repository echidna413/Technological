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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }
        Form formtoopen;

        public AddNewUser(ControlUsers cu)
        {
            InitializeComponent();
            formtoopen = cu;
            // s.BackColor = Color.Pink;
        }
        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //----------------------------------------НУЖНО ЛИ ХЕШИРОВАТЬ ПАРОЛИ?----------------------//

            RegisterUser(UserName.Text, UserPassword.Text, UserRole.Text);
          
        }
        void RegisterUser(string login, string password, string role)
        {
            if (login == "" || password == "" || role == "")
            {
                MessageBox.Show("Введите данные в поля!");

            }
            else
            {
                if (role == "admin" || role == "user" || role == "dismissed")
                {

                    string Connect = @"SERVER=localhost;User Id=root;DATABASE=MY;PORT=3306;password=vilkova199820";
                    MySqlConnection myConnection = new MySqlConnection(Connect);
                    using (myConnection)
                    {
                        var addUserCmd = new MySqlCommand("INSERT INTO `my`.`user` (username,password,role) VALUES (@Login, @Password, @Role)", myConnection);
                        addUserCmd.Parameters.AddWithValue("@Login", login);
                        addUserCmd.Parameters.AddWithValue("@Password", password);
                        addUserCmd.Parameters.AddWithValue("@Role", role);
                        try
                        {
                            myConnection.Open();
                            addUserCmd.ExecuteNonQuery();
                            MessageBox.Show("Новый пользователь успешно добавлен в базу данных!");
                            UserName.Clear();
                            UserPassword.Clear();
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
                    MessageBox.Show("Несуществующая роль! Выберите между: admin или user или dismissed");

                }
            }
        }

        
    
        
    }
}
