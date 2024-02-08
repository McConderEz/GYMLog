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

        public Login()
        {
            InitializeComponent();
            
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {           
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void hideButton_MouseLeave_1(object sender, EventArgs e)
        {
            hideButton.ForeColor = Color.Black;
        }

        private void hideButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hideButton_MouseMove_1(object sender, MouseEventArgs e)
        {
            hideButton.ForeColor = Color.Red;
        }
    }
}
