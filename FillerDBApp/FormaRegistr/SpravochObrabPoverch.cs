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
    public partial class SpravochObrabPoverch : Form
    {
        public SpravochObrabPoverch()
        {
            InitializeComponent();
        }
        Form formtoopen;

        public SpravochObrabPoverch(ChooseSpravoch cs5)
        {
            InitializeComponent();
            formtoopen = cs5;
            // cs.BackColor = Color.Blue;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtoopen.Show();
        }

        private void SpravochObrabPoverch_Load(object sender, EventArgs e)
        {

        }
    }
}
