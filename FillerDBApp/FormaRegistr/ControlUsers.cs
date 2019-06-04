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
    public partial class ControlUsers : Form
    {
        //--------------------------------------ФОРМА ДЛЯ УПРАВЛЕНИЯ ЛЮДЬМИ ВУХАХА--------------------------//

        public ControlUsers()
        {
            InitializeComponent();
        }

        Form formtoopen;

        public ControlUsers(Settings s)
        {
            InitializeComponent();
            formtoopen = s;
            // s.BackColor = Color.Pink;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlUsers_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser anu = new AddNewUser(this);
            anu.Show();
        }

        private void EditPrivilege_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPrivilege ep = new EditPrivilege(this);
            ep.Show();
        }
    }
}
