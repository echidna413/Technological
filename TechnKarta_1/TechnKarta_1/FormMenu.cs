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
    public partial class FormMenu : MetroFramework.Forms.MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();
            DataSet dataSet = new DataSet("Details");
            DataTable dataTable = new DataTable("Detail");
            DataColumn ID = new DataColumn("ID", typeof(int));
            ID.Unique = true;
            ID.AutoIncrement = true;
            ID.AutoIncrementSeed = 1;
            ID.AutoIncrementStep = 1;

            DataColumn Name = new DataColumn("Name", typeof(string));

            dataTable.Columns.AddRange(new DataColumn[] { ID, Name });

            DataRow row1 = dataTable.NewRow();
            row1["Name"] = "Detail1";

            DataRow row2 = dataTable.NewRow();
            row2["Name"] = "Detail2";

            dataTable.Rows.Add(row1);
            dataTable.Rows.Add(row2);

            dataSet.Tables.Add(dataTable);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
                return;
            MessageBox.Show("Деталь добавлена.");
            ListViewItem item = new ListViewItem(textBoxName.Text);
            listView1.Items.Add(item);
            
               
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTabPage6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files(*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            MessageBox.Show("Данные из файла: " + filename + " отправлены на проверку.");
        }

        private void добавитьБазовуюПоверхностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBasePoverch formABP = new FormAddBasePoverch();
            formABP.ShowDialog();
            
        }
        DataTable table = new DataTable();
        private void FormMenu_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Номер поверхности", typeof(int));
            table.Columns.Add("Ориентация поверхности", typeof(int));

            dataGridView1.DataSource = table;
        }

        private void buttonAddPoverch_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox23.Text, textBox24.Text);
            dataGridView1.DataSource = table;
        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
