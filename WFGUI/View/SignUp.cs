using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGUI.View
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            // TODO: Сделать переход в окно авторизации
        }

        private void signUpLabel_MouseLeave(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = Color.Black;
        }

        private void signUpLabel_MouseMove(object sender, MouseEventArgs e)
        {
            signUpLabel.ForeColor = Color.Red;
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
    }
}
