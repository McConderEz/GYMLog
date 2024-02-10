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
using WinFormsGUI.Helper;

namespace WinFormsGUI.View
{
    public partial class MainForm : Form
    {
        private Button _currentButton;
        private Random _random;
        private int _tempIndex;
        private Form _activeForm;
        private UserController _userController;

        public MainForm(/*UserController userController*/)
        {
            InitializeComponent();
            _random = new Random();
            //_userController = userController;


            //Для тестов
            _userController = new UserController("Minoddein", "0958700191");
        }

        private Color SelectThemeColor()
        {
            int index = _random.Next(ThemeColor.ColorList.Count);
            while (_tempIndex == index)
            {
                index = _random.Next(ThemeColor.ColorList.Count);
            }
            _tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    topSideBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in sideBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
            titleLabel.Text = childForm.Text;
        }

        private void ownStatButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOwnStat(_userController), sender);
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrain(), sender);
        }

        private void trainPlanButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrainPlan(_userController), sender);
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRate(), sender);
        }

        private void dietButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDiet(), sender);
        }
    }
}
