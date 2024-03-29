﻿using GYMLog.BL.Controller;
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
    public partial class FormOwnStat : Form
    {
        private UserController _userController;
        private ActivityController _activityController;

        public FormOwnStat(UserController userController)
        {
            InitializeComponent();            
            _userController = userController;
            _activityController = new ActivityController(_userController.CurrentUser);
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            nameLabel.Text += $" {_userController.CurrentUser.Login}";
            birthdayLabel.Text += $" {_userController.CurrentUser.BirthDate.Date.ToString("dd/MM/yyyy")}";
            genderLabel.Text += $" {_userController.CurrentUser.Gender.Name}";
            heightLabel.Text += $" {_userController.CurrentUser.Height}";
            weightLabel.Text += $" {_userController.CurrentUser.Weight}";
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

        private void LoadActivities()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            activityDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Название" });
            activityDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "CaloriesBurned", HeaderText = "Сожжено калорий" });
            activityDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date", HeaderText = "Дата" });
            activityDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Count", HeaderText = "Кол-во сделанных упр." });

            activityDataGridView.DataSource = _activityController.Activities.Where(u => u.User.Login.Equals(_userController.CurrentUser.Login))
                .Select(x => new { x.Name, x.CaloriesBurned, x.Date, x.CompletedExercises.Count}).ToList();
        }

        private void FormOwnStat_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadActivities();
        }
    }
}
