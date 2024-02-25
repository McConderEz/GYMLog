using GYMLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsGUI.Helper;

namespace WinFormsGUI.View
{
    public partial class FormRate : Form
    {
        private ActivityController _activityController;
        private UserController _userController;


        public FormRate(UserController userController)
        {
            InitializeComponent();
            _activityController = new ActivityController(userController.CurrentUser);
            _userController = userController;
        }

        private void FormRate_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        
        private void LoadRateActivityUsers()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            rateDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "User", HeaderText = "Имя" });
            rateDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "ActivityCount", HeaderText = "Кол-во активностей" });

            rateDataGridView.DataSource = _activityController.Activities
                .GroupBy(u => u.User)
                .Select(g => new { User = g.Key, ActivityCount = g.Count() })
                .OrderBy(x => x.ActivityCount).ToList();
        }

        private void activityCountRateButton_Click(object sender, EventArgs e)
        {
            LoadRateActivityUsers();
        }
    }
}
