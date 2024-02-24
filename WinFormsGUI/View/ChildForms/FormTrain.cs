using GYMLog.BL.Controller;
using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsGUI.Helper;

namespace WinFormsGUI.View
{
    public partial class FormTrain : Form
    {
        private UserController _userController;
        private ActivityController _activityController;
        private List<TextBox> _textBoxes;
        private List<NumericUpDown> _numericUpDowns;
        private int Index = 0;
        public FormTrain(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _activityController = new ActivityController(_userController.CurrentUser);
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

        private void LoadExerciseSettings()
        {
            _textBoxes = new List<TextBox>();
            _numericUpDowns = new List<NumericUpDown>();
            var exercise = _activityController.CurrentActivity.WorkoutPlan.ExerciseList.ElementAt(Index);

            ExerciseTitle.Text = exercise.Name;
            exerciseCategoryTitle.Text = exercise.Category;

            for (var i = 0; i < exercise.Sets; i++)
            {
                #region Добавление TextBox
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(10, 0 + i * 20);
                textBox.Size = new Size(80, 20);
                textBox.PlaceholderText = exercise.ExerciseParams.ElementAt(i).Weight.ToString();
                buttonsPanel.Controls.Add(textBox);
                _textBoxes.Add(textBox);
                #endregion

                #region Добавление NumericUpDown
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Location = new System.Drawing.Point(100, 0 + i * 20);
                numericUpDown.Size = new Size(40, 20);
                numericUpDown.Value = exercise.ExerciseParams.ElementAt(i).Iterations;
                buttonsPanel.Controls.Add(numericUpDown);
                _numericUpDowns.Add(numericUpDown);
                #endregion
            }
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

        private void FormTrain_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadDataWorkoutPlans();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {

        }

        private void exCompletedButton_Click(object sender, EventArgs e)
        {

        }

        private void rightButton_Click(object sender, EventArgs e)
        {

        }


        private void rightButton_MouseLeave(object sender, EventArgs e)
        {
            rightButton.Image = new Bitmap(@"C:\Users\rusta\source\repos\GYMLog\WinFormsGUI\Resources\icons8-стрелка-вправо-в-круге-50.png");
        }

        private void rightButton_MouseMove(object sender, MouseEventArgs e)
        {
            rightButton.Image = new Bitmap(@"C:\Users\rusta\source\repos\GYMLog\WinFormsGUI\Resources\icons8-стрелка-вправо-в-круге-50 (1).png");
        }

        private void exCompletedButton_MouseLeave(object sender, EventArgs e)
        {
            exCompletedButton.Image = new Bitmap(@"C:\Users\rusta\source\repos\GYMLog\WinFormsGUI\Resources\icons8-выполнено-50.png");
        }

        private void exCompletedButton_MouseMove(object sender, MouseEventArgs e)
        {
            exCompletedButton.Image = new Bitmap(@"C:\Users\rusta\source\repos\GYMLog\WinFormsGUI\Resources\icons8-выполнено-50 (1).png");
        }

        private void leftButton_MouseLeave(object sender, EventArgs e)
        {
            leftButton.Image = new Bitmap(@"C:\Users\rusta\source\repos\GYMLog\WinFormsGUI\Resources\icons8-стрелка-влево-в-круге-50.png");
        }

        private void leftButton_MouseMove(object sender, MouseEventArgs e)
        {
            leftButton.Image = new Bitmap(@"C:\Users\rusta\source\repos\GYMLog\WinFormsGUI\Resources\icons8-стрелка-влево-в-круге-50 (1).png");
        }

        private void startTrain_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = trainPlanDataGridView.SelectedRows[0].Index;

                if (index != null)
                {
                    _activityController.Start(_userController.CurrentUser.WorkoutPlans.ElementAt((int)index));
                    LoadExerciseSettings();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }
    }
}
