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
    public partial class FormKodOborudov : Form
    {
        public FormKodOborudov()
        {
            //---------------------------ФОРМА ВЫБОРА КОДА ОБОРУДОВАНИЯ--------------------------//
            InitializeComponent();
        }
        Form formtoopen;

        public FormKodOborudov(FormChooser fc1)
        {
            InitializeComponent();
            formtoopen = fc1;
            //проверка fc.BackColor = Color.Yellow;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //---------------------------ПЕРЕХОД НА ФОРМУ ВЫБОРА КОДА ПРИСПОСОБЛЕНИЯ--------------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKodPrisposobl fkp = new FormKodPrisposobl();
            fkp.Show();
        }
      
        //---------------------------ПЕРЕХОД НА ФОРМУ НАЗАД--------------------------//

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            //======================================ИСКЛЮЧЕНИЕ formtoopen=null!!!!!!!---------------------------------------//
            try
            {
                formtoopen.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
