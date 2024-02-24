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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsGUI.View
{
    public partial class FormTrain : Form
    {
        private UserController _userController;
        private ActivityController _activityController;
        private List<System.Windows.Forms.TextBox> _textBoxes;
        private List<NumericUpDown> _numericUpDowns;
        private int Index = 0;
        private DateTime startTime;

        public FormTrain(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _activityController = new ActivityController(_userController.CurrentUser);
            LoadDataWorkoutPlans();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void LoadDataExercises(int index)
        {
            ExerciseDataGridView.DataBindings.Clear();
            ExerciseDataGridView.Columns.Clear();

            var item = _userController.CurrentUser.WorkoutPlans.ElementAt(index);
            #region Колонки
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Название упр." });
            ExerciseDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Категория" });
            #endregion
            ExerciseDataGridView.AutoGenerateColumns = false;
            ExerciseDataGridView.DataSource = item.ExerciseList;

            DataGridViewRow row = ExerciseDataGridView.Rows[Index];
            row.DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void LoadExerciseSettings()
        {

            Clear();

            _textBoxes = new List<System.Windows.Forms.TextBox>();
            _numericUpDowns = new List<NumericUpDown>();
            var exercise = _activityController.CurrentActivity.WorkoutPlan.ExerciseList.ElementAt(Index);

            for (var i = 0; i < exercise.Sets; i++)
            {
                #region Добавление TextBox
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
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

        private void Clear()
        {
            if (_textBoxes != null || _numericUpDowns != null)
            {
                foreach (System.Windows.Forms.TextBox textBox in _textBoxes)
                {
                    Controls.Remove(textBox);
                    textBox.Dispose();
                }

                foreach (NumericUpDown numeric in _numericUpDowns)
                {
                    Controls.Remove(numeric);
                    numeric.Dispose();
                }

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
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ExerciseDataGridView.Rows[Index];
            row.DefaultCellStyle.BackColor = Color.White;
            Index = Index == 0 ? ExerciseDataGridView.Rows.Count - 1 : Index - 1;

            row = ExerciseDataGridView.Rows[Index];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            LoadExerciseSettings();
        }

        private void exCompletedButton_Click(object sender, EventArgs e)
        {

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ExerciseDataGridView.Rows[Index];
            row.DefaultCellStyle.BackColor = Color.White;
            Index = Index == ExerciseDataGridView.Rows.Count - 1 ? 0 : Index + 1;

            row = ExerciseDataGridView.Rows[Index];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            LoadExerciseSettings();
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
                startTime = DateTime.Now;
                if (index != null)
                {
                    _activityController.Start(_userController.CurrentUser.WorkoutPlans.ElementAt((int)index));
                    trainTime.Start();
                    LoadExerciseSettings();
                    LoadDataExercises((int)index);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }

        private void UpdateElapsedTime()
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            time.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void trainTime_Tick(object sender, EventArgs e)
        {
            UpdateElapsedTime();
        }
    }
}
