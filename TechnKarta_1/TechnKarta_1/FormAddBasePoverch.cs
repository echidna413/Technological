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
    public partial class FormAddBasePoverch : MetroFramework.Forms.MetroForm
    {
        public FormAddBasePoverch()
        {
            InitializeComponent();
        }

        private void FormAddBasePoverch_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPoverch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поверхность добавлена.");
        }
    }
}
