using MySql.Data.MySqlClient;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            textLogin.Text = "Введите логин";
            textPass.Text = "Введите пароль";
            if (textPass.Text == "Введите пароль")
            {
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLogin_Enter(object sender, EventArgs e)
        {
            if (textLogin.Text == "Введите логин")
                textLogin.Text = "";
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
                textLogin.Text = "Введите логин";
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Введите пароль")
            {
                textPass.Text = "";
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Введите пароль";
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (textPass.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists())
                return;

            DBPersonal dBPersonal = new DBPersonal();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `Users` (`login`, `pass`) VALUES (@login, @pass)", dBPersonal.getConnection());
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = textLogin.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textPass.Text;

            dBPersonal.openConnetion();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
                MessageBox.Show("Аккаунт не был создан");

            dBPersonal.closeConnetion();
        }

        public Boolean isUserExists()
        {
            DBPersonal dbpersonal = new DBPersonal();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login`= @ul ", dbpersonal.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = textLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользовательно уже есть!");
                return true;
            }
            else
            {   
                return false;
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
