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
    public partial class ChooseSpravoch : Form
    {
        public ChooseSpravoch()
        {
            //----------------------ФОРМА, ГДЕ УМНЫЕ ЛЮДИ ВЫБИРАЮТ, КАКИЕ СПРАВОЧНИКИ РЕДАКТИРОВАТЬ (ТОЛЬКО ДЛЯ АДМИНА)---------------------//

            InitializeComponent();
        }

        Form formtoopen;

        public ChooseSpravoch(Settings s3)
        {
            InitializeComponent();
            formtoopen = s3;
            // s3.BackColor = Color.Green;
        }
        //--------------------------------------ПЕРЕХОД В РЕДАКТИРОВАНИЕ СПРАВОЧНИКА КОДОВ ОБОРУДОВАНИЯ--------------------------//

        private void SpravKodOborud_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpravochOborud sprob = new SpravochOborud(this);
            sprob.Show();
        }

        //------------------------------------------------ВЫХОД НАЗАД В НАСТРОЙКИ-----------------------------------------------------//

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        //--------------------------------------ПЕРЕХОД В РЕДАКТИРОВАНИЕ СПРАВОЧНИКА КОДОВ ТЕХНИЧЕСКОГО ПЕРЕХОДА--------------------------//

        private void SpravKodTechn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpravochTechnPer stp = new SpravochTechnPer(this);
            stp.Show();
        }

        //--------------------------------------ПЕРЕХОД В РЕДАКТИРОВАНИЕ СПРАВОЧНИКА КОДОВ ОБРАБАТЫВАЕМОЙ ПОВЕРХНОСТИ--------------------------//

        private void SpravKodObrabPov_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpravochObrabPoverch sop = new SpravochObrabPoverch(this);
            sop.Show();
        }

        //--------------------------------------ПЕРЕХОД В РЕДАКТИРОВАНИЕ СПРАВОЧНИКА КОДОВ ПРИСПОСОБЛЕНИЙ--------------------------//

        private void SpravPrisposob_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpravochPrisposob sp = new SpravochPrisposob(this);
            sp.Show();
        }

        private void ChooseSpravoch_Load(object sender, EventArgs e)
        {

        }
    }
}
