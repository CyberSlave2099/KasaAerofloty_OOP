using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Сoursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PassField.AutoSize = false;
            PassField.Size = new Size(PassField.Size.Width, 64);
        }

        private void PassField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string pass = "223";
            string login = "S";
            if (LoginField.Text == login && PassField.Text == pass)
            {
                this.Hide();
                Main_Form main = new Main_Form();
                main.Show();
            }
            else
            {
                MessageBox.Show("Логін або пароль були введені неправильно");
            }
        }
    }
    
}
