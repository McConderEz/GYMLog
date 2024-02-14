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
    public partial class EditWorkoutPlan : Form
    {
        private WorkoutPlanController _workoutPlanController;
        private WorkoutPlan item;
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

        public EditWorkoutPlan(WorkoutPlanController workoutPlanController, int index)
        {
            InitializeComponent();
            _workoutPlanController = workoutPlanController;
            item = _workoutPlanController.userController.CurrentUser.WorkoutPlans.ElementAt(index);
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

        private void editButton_Click(object sender, EventArgs e)
        {
            string planName = planNameTextBox.Text;
            string description = descriptionTextBox.Text;

            if (!string.IsNullOrWhiteSpace(planName))
            {
                item.PlanName = planName;
                item.Notes = description;
                _workoutPlanController.Update(item);
                MessageBox.Show("Запись успешно Изменена!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }

        }
    }
}
