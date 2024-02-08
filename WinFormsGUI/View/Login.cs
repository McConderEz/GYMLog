using GYMLog.BL.Controller;
using WinFormsGUI.View;

namespace WinFormsGUI
{
    public partial class Login : Form
    {

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

        private UserController _userController;

        public Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }


        private void signUpButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.ForeColor = Color.Black;
        }

        private void signUpButton_MouseMove(object sender, MouseEventArgs e)
        {
            signUpButton.ForeColor = Color.Red;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                _userController = new UserController(login, password);
                if(_userController.CurrentUser != null)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Введены неверные данные или пользователя не существует!");
                }
            }

        }

        

    }
}
