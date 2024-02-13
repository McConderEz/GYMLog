﻿using GYMLog.BL.Controller;
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
        private UserController _userController;
        private WorkoutPlanController _workoutPlanController;
        public FormTrainPlan(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _workoutPlanController = new WorkoutPlanController(_userController.CurrentUser);
            _workoutPlanController.WorkoutPlanChanged += RefreshUserController;
            _workoutPlanController.WorkoutPlanChanged += RefreshDataGridView;
            _workoutPlanController.WorkoutPlanChanged += RefreshExerciseDataGridView;
            LoadDataWorkoutPlans();
        }

        
        private void LoadDataWorkoutPlans()
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

        //TODO: Сделать обновление dataGridView после изменение данных
        private void RefreshExerciseDataGridView(object? sender, EventArgs e)
        {
            ExerciseDataGridView.DataBindings.Clear ();
            //LoadDataExercises();
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
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }

        private void changeTrainPlan_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = trainPlanDataGridView.SelectedRows[0].Index;

                if (index != null)
                {
                    _workoutPlanController.Update((int)index);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }

        private void OutputExerciseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = trainPlanDataGridView.SelectedRows[0].Index;

                if (index != null)
                {
                    LoadDataExercises((int)index);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }


        private void LoadDataExercises(int index)
        {

            var item = _userController.CurrentUser.WorkoutPlans.ElementAt(index);
            // Тестовые входные
            item.ExerciseList.Add(new WorkoutExercise
            {
                Name = "asdas",
                Category = "asdada",
                ExerciseParams = new List<ExerciseParams> { new ExerciseParams(4, 5) },
                Sets = 1,
                Intensity = 1,
            });

            #region Колонки
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Название упр." });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Категория" });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "CaloriesBurned", HeaderText = "Калории" });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date", HeaderText = "Дата" });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Duration", HeaderText = "Длительность" });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Intensity", HeaderText = "Интенсивность" });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Sets", HeaderText = "Количество подходов" });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Description", HeaderText = "Описание" });
            #endregion

            DataGridViewButtonColumn exerciseParamsColumn = new DataGridViewButtonColumn();
            exerciseParamsColumn.HeaderText = "Повт./вес";
            exerciseParamsColumn.Text = "View";
            exerciseParamsColumn.UseColumnTextForButtonValue = true;
            exerciseParamsColumn.Name = "ExerciseParams";
            exerciseParamsColumn.FlatStyle = FlatStyle.Popup;

            // Добавление столбца в DataGridView
            ExerciseDataGridView.Columns.Add(exerciseParamsColumn);

            // Обработчик события нажатия на кнопку для просмотра ExerciseParams
            ExerciseDataGridView.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == ExerciseDataGridView.Columns["ExerciseParams"].Index && e.RowIndex >= 0)
                {
                    // Получение объекта WorkoutExercise из выбранной строки
                    WorkoutExercise workoutExercise = ExerciseDataGridView.Rows[e.RowIndex].DataBoundItem as WorkoutExercise;

                    // Отображение ExerciseParams в MessageBox
                    string exerciseParamsText = string.Join(", ", workoutExercise.ExerciseParams.Select(ep => $"{ep.Iterations}, {ep.Weight}"));
                    MessageBox.Show(exerciseParamsText, "Повт./вес");
                }
            };
            ExerciseDataGridView.AutoGenerateColumns = false;
            ExerciseDataGridView.DataSource = item.ExerciseList;

        }

        private void addExerciseInPlanButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = trainPlanDataGridView.SelectedRows[0].Index;

                if (index != null)
                {
                    AddExerciseInPlan addExerciseInPlan = new AddExerciseInPlan(_workoutPlanController);
                    addExerciseInPlan.Show();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }
    }
}
