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
    public partial class AddNewWorkoutPlan : Form
    {

        private WorkoutPlanController _workoutPlanController;



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
        

        public AddNewWorkoutPlan(WorkoutPlanController workoutPlanController)
        {
            InitializeComponent();
            _workoutPlanController = workoutPlanController;
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
            string planName = planNameTextBox.Text;
            string description = descriptionTextBox.Text;

            if(!string.IsNullOrWhiteSpace(planName))
            {
                WorkoutPlan plan = new WorkoutPlan(planName, description);
                _workoutPlanController.Add(plan);
                MessageBox.Show("Запись успешно добавлена!");               
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}
