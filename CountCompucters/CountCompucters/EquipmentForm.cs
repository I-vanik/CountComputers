using MlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountCompucters
{
    public partial class EquipmentForm : Form
    {
        MainForm mainForm;
        public EquipmentForm(MainForm mn)
        {
            InitializeComponent();
            this.mainForm = mn;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
          
            mainForm.dataGridView1.Rows.Add(textBoxID.Text);
            this.Hide();
        }
    }
}
