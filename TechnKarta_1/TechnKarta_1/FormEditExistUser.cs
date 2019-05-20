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
    public partial class FormEditExistUser : Form
    {
        public FormEditExistUser()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormSettings formS = new FormSettings();
            formS.ShowDialog();
            Close();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormEditUserData formEUD = new FormEditUserData();
            formEUD.ShowDialog();
            Close();
        }
        // Здесь отправка изменённых данных о пользователе
        private void buttonEndAdd_Click(object sender, EventArgs e)
        {
            if(textBoxCurrentName.Text != null && textBoxName != null)
            {
                MessageBox.Show("Данные изменены.");
            }
        }
    }
}
