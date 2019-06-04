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
    public partial class FormEditUserData : Form
    {
        public FormEditUserData()
        {
            InitializeComponent();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            Hide();
            FormEditExistUser EditExistUser = new FormEditExistUser();
            EditExistUser.ShowDialog();
            Close();
        }

        private void FormEditUserData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormSettings FormS = new FormSettings();
            FormS.ShowDialog();
            Close();
        }

        private void buttonEndAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxName.Text);
            if (textBoxName.Text == "" || textBoxPass.Text == "" || textBoxRole.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                
            }
            else MessageBox.Show("Новый пользователь зарегистрирован.");
        }
    }
}
