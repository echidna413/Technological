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
    public partial class SpravochOborud : Form
    {
        public SpravochOborud()
        {
            InitializeComponent();
        }
        Form formtoopen;

        public SpravochOborud(ChooseSpravoch cs2)
        {
            InitializeComponent();
            formtoopen = cs2;
            // cs.BackColor = Color.Blue;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        private void SpravochOborud_Load(object sender, EventArgs e)
        {

        }
    }
}
