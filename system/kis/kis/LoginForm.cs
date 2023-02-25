using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kis
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataBaseManager dbManager = new DataBaseManager();

            String[] userInfo = dbManager.UserAuthorize(userNameText.Text, userPasswordText.Text).Split(' ');

            if(userInfo[1] == "administrator")
            {
                this.Hide();
                AdminForm adminForm = new AdminForm(userInfo[0]);
                adminForm.Show();
            }
            else if(userInfo[1] == "manager")
            {
                this.Hide();
                UserForm userForm = new UserForm(userInfo[0]);
                userForm.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Неправильный логин или пароль",
                    "Ошибка входа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.OK)
                {
                    userNameText.Clear();
                    userPasswordText.Clear();
                }
            }
        }
    }
}
