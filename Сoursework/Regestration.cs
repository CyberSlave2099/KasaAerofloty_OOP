using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Сoursework
{
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;

            userSurnameField.AutoSize = false;
            userSurnameField.Size = new Size(350, 64);
            PassField.AutoSize = false;
            PassField.Size = new Size(350, 64);

        }

        private void Regestration_Load(object sender, EventArgs e)
        {

        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите имя")
                userNameField.Text = "";
            userNameField.ForeColor = Color.Black;
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
                
            
        }
        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
                userSurnameField.Text = "";
            userSurnameField.ForeColor = Color.Black;
        }
        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
                
        }

        

        private void userNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if(LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            } 

        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
                LoginField.Text = "";
            LoginField.ForeColor = Color.Black;
        }

        private void PassField_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
