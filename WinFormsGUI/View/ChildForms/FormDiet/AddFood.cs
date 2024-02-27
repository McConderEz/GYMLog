using GYMLog.BL.Controller;
using GYMLog.BL.Model;
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

namespace WinFormsGUI.View.ChildForms.FormDiet
{
    public partial class AddFood : Form
    {
        private EatingController _eatingController;

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

        public AddFood(EatingController eatingController)
        {
            InitializeComponent();
            _eatingController = eatingController;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           // try
            {
                string name = foodName.Text;
                double proteins = double.Parse(proteinsTextBox.Text);
                double fats = double.Parse(fatsTextBox.Text);
                double carbohydrates = double.Parse(carbohydratesTextBox.Text);
                double calories = double.Parse(caloriesTextBox.Text);
                double weight = double.Parse(weightTextBox.Text);
                _eatingController.Add(new Food
                {
                    Name = name,
                    Proteins = proteins,
                    Fats = fats,
                    Carbohydrates = carbohydrates,
                    Calories = calories
                }, weight);                
                this.Dispose();
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Неверный формат данных!");
            //}
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
    }
}
