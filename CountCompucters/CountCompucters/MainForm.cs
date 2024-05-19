using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountCompucters
{
    public partial class MainForm : Form
    {

        DataTable table = new DataTable("table");


        public MainForm(DataTable tb)
        {
            InitializeComponent();
            this.table = tb;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonCreate_Click(object sender, EventArgs e)
        {
            EquipmentForm equipmentForm = new EquipmentForm(this);
            equipmentForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Наименование", Type.GetType("System.String"));
            table.Columns.Add("Тип оборудования", Type.GetType("System.String"));
            table.Columns.Add("Статус", Type.GetType("System.String"));
            table.Columns.Add("Дата статуса", Type.GetType("System.Int32"));
            table.Columns.Add("Серийный №", Type.GetType("System.String"));
            table.Columns.Add("Помещение", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        public void ButtonAdd()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
