using GYMLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGUI.View
{
    public partial class SignUp : Form
    {

        private UserController _userController;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }

            base.WndProc(ref m);
        }

        public SignUp()
        {
            InitializeComponent();
            _userController = new UserController("test", "test");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (login != null)
            {
                login.Dispose();
            }
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.Black;
        }

        private void exitButton_MouseMove(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.Red;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hideButton_MouseLeave(object sender, EventArgs e)
        {
            hideButton.ForeColor = Color.Black;
        }

        private void hideButton_MouseMove(object sender, MouseEventArgs e)
        {
            hideButton.ForeColor = Color.Red;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (login != null)
            {
                login.Show();
                this.Dispose();
            }
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
        }

        private void loginButton_MouseMove(object sender, MouseEventArgs e)
        {
            loginButton.ForeColor = Color.Red;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            try
            {
                string login = userNameTextBox.Text;
                string password = passwordTextBox.Text;
                string gender = genderComboBox.SelectedItem.ToString();
                DateTime birthday = ageTimePicker.Value;
                double height = double.Parse(heightTextBox.Text);
                double weight = double.Parse(weightTextBox.Text);

                if(password.Length < 8)
                {
                    //TODO: Сделать хранения пароля в хэше
                    MessageBox.Show("Длина пароля должна быть минимум 8 символов!");
                    return;
                }

                if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Не все поля были заполнены!");
                    return;
                }

                if(!_userController.CheckFreeUserName(login)) 
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }
                else
                {
                    _userController.RegisterNewUser(login, password);
                    _userController.SetNewUserData(gender,birthday,weight,height);
                    MessageBox.Show("Пользователь зарегистрирован!");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неверный формат данных!");
            }
                    
        }
        
    }
}
