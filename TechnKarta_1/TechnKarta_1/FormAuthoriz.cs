using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnKarta_1
{
    public partial class FormAuthorization : MetroFramework.Forms.MetroForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthoriz_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string pass = textBoxPass.Text;

            // Здесь я вставила роль чисто для проверки, но это нужно брать из бд
            string role = "admin";

            if (role == "admin")
            {
                Data.Value = "admin";
            }
            else
            {
                Data.Value = "user";
            }

            if (name == "sasha" && pass == "1234")
            {
                Hide();
                FormMenu FormMenu = new FormMenu();
                FormMenu.ShowDialog();
                Close();//это закрывает первую форму?
            }
            else MetroFramework.MetroMessageBox.Show(this, "Неверное имя пользователя или пароль", "Сообщение", MessageBoxButtons.OK);
               // MessageBox.Show("Неверное имя пользователя или пароль!");
           
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
