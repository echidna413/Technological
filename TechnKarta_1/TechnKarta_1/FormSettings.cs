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
    public partial class FormSettings : MetroFramework.Forms.MetroForm
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormChoice formC = new FormChoice();
            formC.ShowDialog();
            Close();
        }

        private void buttonSettingsUser_Click(object sender, EventArgs e)
        {
            Hide();
            FormEditUserData FormEUD = new FormEditUserData();
            FormEUD.ShowDialog();
            Close();
        }

        private void buttonSettingsBooks_Click(object sender, EventArgs e)
        {
            Hide();
            FormEditBooks FormEB = new FormEditBooks();
            FormEB.ShowDialog();
            Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
