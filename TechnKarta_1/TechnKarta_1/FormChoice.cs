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
    public partial class FormChoice : Form
    {
        public FormChoice()
        {
            InitializeComponent();
          

        }
       
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
           
        }

        private void FormChoice_Load(object sender, EventArgs e)
        {
            if (Data.Value != "admin")
            {
                buttonSettings.Hide();
            }
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            Hide();
            FormAddData formAD1 = new FormAddData();
            formAD1.ShowDialog();
            Close();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files(*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            MessageBox.Show("Данные из файла: " + filename + " отправлены на проверку.");
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Hide();
            FormSettings formS = new FormSettings();
            formS.ShowDialog();
            Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Hide();
            FormExport formE = new FormExport();
            formE.ShowDialog();
            Close();
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            Hide();
            FormMenu formM = new FormMenu();
            formM.ShowDialog();
            Close();

        }
    }
}
