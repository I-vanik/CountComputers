using System;
using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            textLogin.Text = "Введите логин";

            textPass.Text = "Введите пароль";
            if (textPass.Text == "Введите пароль")
            {
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            String loginUser = textLogin.Text;
            String passUser = textPass.Text;

            DBPersonal dbpersonal = new DBPersonal();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login`=@ul AND `pass`=@up", dbpersonal.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void textLogin_Enter_1(object sender, EventArgs e)
        {
            if (textLogin.Text == "Введите логин")
                textLogin.Text = "";
        }

        private void textLogin_Leave_1(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
                textLogin.Text = "Введите логин";
        }

        private void textPass_Enter_1(object sender, EventArgs e)
        {
            if (textPass.Text == "Введите пароль")
            {
                textPass.Text = "";
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave_1(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Введите пароль";
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void RegisterLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
