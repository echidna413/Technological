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
    public partial class FormKodPrisposobl : Form
    {
        public FormKodPrisposobl()
        {
            //---------------------------ФОРМА ВЫБОРА КОДА ПРИСПОСОБЛЕНИЯ--------------------------//

            InitializeComponent();
        }

        //---------------------------ПЕРЕХОД НА ФОРМУ НАЗАД--------------------------//

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKodOborudov fko = new FormKodOborudov();
            fko.Show();
        }

        private void FormKodPrisposobl_Load(object sender, EventArgs e)
        {

        }

        //private void Vvod_dannyh_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    SpravochPrisposob sp = new SpravochPrisposob();
        //    sp.Show();
        //}

        //---------------------------ПЕРЕХОД НА ФОРМУ ВЫБОРА КОДА ТЕХНИЧЕСКОГО ПРИСПОСОБЛЕНИЯ--------------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKodTechnPer fktp = new FormKodTechnPer();
            fktp.Show();
        }
    }
}
