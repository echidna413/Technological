using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaRegistr
{
    public partial class FormKodTechnPer : Form
    {
        //---------------------------ФОРМА ВЫБОРА КОДА ТЕХНИЧЕСКОГО ПРИСПОСОБЛЕНИЯ--------------------------//

        public FormKodTechnPer()
        {
            InitializeComponent();
        }

        //---------------------------ПЕРЕХОД НА ФОРМУ НАЗАД--------------------------//

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKodPrisposobl fkp = new FormKodPrisposobl();
            fkp.Show();
        }

        //---------------------------ПЕРЕХОД НА ГЛАВНУЮ ФОРМУ С ТАБЛИЦЕЙ РАЗМЕРОМ СО ВСЕЛЕННУЮ--------------------------//

        private void Next_Click(object sender, EventArgs e)
        {

        }


        private void FormKodTechnPer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
