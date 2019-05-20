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
    public partial class FormAddData : Form
    {
        public FormAddData()
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }
    }
}
