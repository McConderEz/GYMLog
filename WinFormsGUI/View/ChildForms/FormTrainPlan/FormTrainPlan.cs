using GYMLog.BL.Controller;
using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WinFormsGUI.Helper;
using WinFormsGUI.View.ChildForms.FormTrainPlan;

namespace WinFormsGUI.View
{
    public partial class FormTrainPlan : Form
    {
        //TODO: Добавить составную форму связи, WorkoutPlan в одной dgv и WorkoutExercise в другой dgv
        private UserController _userController;
        private WorkoutPlanController _workoutPlanController;
        public FormTrainPlan(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _workoutPlanController = new WorkoutPlanController(_userController.CurrentUser);
            _workoutPlanController.WorkoutPlanChanged += RefreshUserController;
            _workoutPlanController.WorkoutPlanChanged += RefreshDataGridView;
            LoadData();
        }

        //TODO: Сделать обновление dataGridView после изменение данных
        private void LoadData()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Название плана";
            column.DataPropertyName = "PlanName";
            trainPlanDataGridView.Columns.Add(column);
            trainPlanDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            trainPlanDataGridView.DataSource = _userController.CurrentUser.WorkoutPlans
                                                              .Select(x => new { PlanName = x.PlanName }).ToList();
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

        private void FormTrainPlan_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            AddNewWorkoutPlan addNewWorkoutPlan = new AddNewWorkoutPlan(_workoutPlanController);
            addNewWorkoutPlan.Show();            
        }

        private void RefreshUserController(object? sender, EventArgs e)
        {
            var user = _userController.CurrentUser;
            _userController = new UserController(user.Login, user.Password);
        }

        private void RefreshDataGridView(object? sender, EventArgs e)
        {
            trainPlanDataGridView.DataBindings.Clear();
            trainPlanDataGridView.DataSource = _userController.CurrentUser.WorkoutPlans
                                                              .Select(x => new { PlanName = x.PlanName }).ToList();
        }

        private void deletePlanButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = trainPlanDataGridView.SelectedRows[0].Index;

                if (index != null)
                {
                    _workoutPlanController.Delete((int)index);
                }
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }
    }
}
