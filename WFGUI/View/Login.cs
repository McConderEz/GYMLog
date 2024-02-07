using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGUI.View;

namespace WFGUI
{
    public partial class Login : Form
    {        
        public Login()
        {
            InitializeComponent();
            
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hideButton_MouseLeave(object sender, EventArgs e)
        {
            hideButton.ForeColor = Color.Black;
        }

        private void hideButton_MouseMove(object sender, MouseEventArgs e)
        {
            hideButton.ForeColor = Color.Red;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void signUpLabel_MouseMove(object sender, MouseEventArgs e)
        {
            signUpLabel.ForeColor = Color.Red;
        }

        private void signUpLabel_MouseLeave(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = Color.Black;
        }

        private void exitButton_MouseMove_1(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.Red;
        }

        private void exitButton_MouseLeave_1(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.Black;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
