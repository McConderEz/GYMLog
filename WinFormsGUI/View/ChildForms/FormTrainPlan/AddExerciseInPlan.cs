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
using System.Windows.Forms;

namespace WinFormsGUI.View.ChildForms.FormTrainPlan
{
    public partial class AddExerciseInPlan : Form
    {
        //TODO: Сделать возможность добавлять своё упражнение
        private List<TextBox> _textBoxes;
        private List<NumericUpDown> _numericUpDowns;
        private WorkoutPlanController _workoutPlanController;
        private ExerciseController _exerciseController;

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


        public AddExerciseInPlan(WorkoutPlanController workoutPlanController, WorkoutPlan workoutPlan)
        {
            InitializeComponent();
            _workoutPlanController = workoutPlanController;
            _workoutPlanController.WorkoutPlan = workoutPlan;

            var categories = _workoutPlanController.Exercises.Select(c => c.Category).Distinct().ToArray();
            categoryComboBox.Items.AddRange(categories);
        }

        private void setsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            int count;

            if (!string.IsNullOrWhiteSpace(setsCountTextBox.Text) && int.TryParse(setsCountTextBox.Text, out count))
            {
                if (_textBoxes != null || _numericUpDowns != null)
                {
                    foreach (TextBox textBox in _textBoxes)
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

                _textBoxes = new List<TextBox>();
                _numericUpDowns = new List<NumericUpDown>();

                for (var i = 0; i < count; i++)
                {
                    #region Добавление TextBox
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(10, 0 + i * 20);
                    textBox.Size = new Size(80, 20);
                    textBox.PlaceholderText = "Введите вес";
                    buttonsPanel.Controls.Add(textBox);
                    _textBoxes.Add(textBox);
                    #endregion

                    #region Добавление NumericUpDown
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Location = new System.Drawing.Point(100, 0 + i * 20);
                    numericUpDown.Size = new Size(40, 20);
                    buttonsPanel.Controls.Add(numericUpDown);
                    _numericUpDowns.Add(numericUpDown);
                    #endregion
                }
            }
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = exerciseComboBox.SelectedItem.ToString();
                string category = categoryComboBox.SelectedItem.ToString();
                int sets = int.Parse(setsCountTextBox.Text);
                string description = descriptionTextBox.Text;

                if ((!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(category)) && (_numericUpDowns.Count > 0 && _textBoxes.Count > 0) && sets > 0)
                {
                    _exerciseController = new ExerciseController(name, category);

                    List<ExerciseParams> exerciseParams = new List<ExerciseParams>();

                    for (var i = 0; i < sets; i++)
                    {
                        exerciseParams.Add(new ExerciseParams
                        {
                            Iterations = (int)_numericUpDowns[i].Value,
                            Weight = double.Parse(_textBoxes[i].Text)
                        });
                    }

                    _workoutPlanController.Add(_exerciseController.CurrentExercise, sets, exerciseParams);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный ввод данных!");
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseComboBox.Items.Clear();
            var exercises = _workoutPlanController.Exercises.Where(c => c.Category.Equals(categoryComboBox.SelectedItem.ToString()))
                .Select(e => e.Name).ToArray();
            exerciseComboBox.Items.AddRange(exercises);
        }
    }
}
