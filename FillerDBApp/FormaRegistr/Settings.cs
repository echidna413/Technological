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
    public partial class Settings : Form
    {
        //---------------------------ВСЯКИЕ НАСТРОЙКИ--------------------------//

        public Settings()
        {
            InitializeComponent();
        }
        Form formtoopen;
        public Settings(FormChooser fc3)
        {
            InitializeComponent();
            formtoopen = fc3;
            // fc3.BackColor = Color.Green;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormChooser frm3 = new FormChooser();
            //frm3.Show();
            this.Hide();
            formtoopen.Show();
        }

        //---------------------------НАСТРОЙКИ СПРАВОЧНИКОВ--------------------------//

        private void SettingsSpravoch_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseSpravoch cs = new ChooseSpravoch(this);
            cs.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        //---------------------------НАСТРОЙКИ ЮЗЕРОВ--------------------------//

        private void ControlUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlUsers cu = new ControlUsers(this);
            cu.Show();
        }

        //---------------------------НАСТРОЙКИ БАЗЫ ДАННЫХ--------------------------//

        private void SettingsDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsDB sdb = new SettingsDB(this);
            sdb.Show();
        }
    }
}
