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
    public partial class SettingsDB : Form
    {
        public SettingsDB()
        {
            InitializeComponent();
        }

        Form formtoopen;

        public SettingsDB(Settings s1)
        {
            InitializeComponent();
            formtoopen = s1;
            // s1.BackColor = Color.Yellow;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        private void SettingsDB_Load(object sender, EventArgs e)
        {

        }
    }
}
