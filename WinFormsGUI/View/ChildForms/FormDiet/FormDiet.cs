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
using WinFormsGUI.Helper;
using WinFormsGUI.View.ChildForms.FormDiet;

namespace WinFormsGUI.View
{
    public partial class FormDiet : Form
    {
        private UserController _userController;
        private EatingController _eatingController;


        public FormDiet(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _eatingController = new EatingController(_userController);
          
            _eatingController.EatingAdded += RefreshUserController;
            _eatingController.EatingAdded += RefreshEatings;
        }

        private void RefreshEatings(object? sender, EventArgs e)
        {
            LoadDataEatings();
        }

        private void RefreshUserController(object? sender, EventArgs e)
        {
            var user = _userController.CurrentUser;
            _userController = new UserController(user.Login, user.Password);
            MainForm._userController = _userController;
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

        private void LoadDataEatings()
        {
            eatingsDataGridView.DataBindings.Clear();
            eatingsDataGridView.Columns.Clear();

            #region Колонки
            eatingsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Moment", HeaderText = "Дата" });
            eatingsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Calories", HeaderText = "Калорийность" });
            eatingsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Название еды" });
            eatingsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Proteins", HeaderText = "Белки" });
            eatingsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Fats", HeaderText = "Жиры" });
            eatingsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Carbohydrates", HeaderText = "Углеводы" });
            #endregion

            eatingsDataGridView.AutoGenerateColumns = false;

            var dataSource = _eatingController.userController.CurrentUser.Eatings.Select(x => new
            {
                Moment = x.Moment,
                Calories = x.Foods.Sum(g => Math.Round(g.Food.CaloriesOneGramm / g.Weight, 2)),
                Name = string.Join(", ", x.Foods.Select(f => f.Food.Name)),
                Proteins = x.Foods.Sum(g => Math.Round(g.Food.ProteinsOneGramm / g.Weight, 2)),
                Fats = x.Foods.Sum(g => Math.Round(g.Food.FatsOneGramm / g.Weight, 2)),
                Carbohydrates = x.Foods.Sum(g => Math.Round(g.Food.CarbohydratesOneGramm / g.Weight, 2))
            }).ToList();
            eatingsDataGridView.DataSource = dataSource;           
        }

        private void FormDiet_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadDataEatings();
        }

        private void AddNewEatingButton_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(_eatingController);
            addFood.Show();
        }

        private void DeleteEatingButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = eatingsDataGridView.SelectedRows[0].Index;

                if (index != null)
                {
                    var temp = _userController.CurrentUser.Eatings.ElementAt((int)index);
                    _userController.CurrentUser.Eatings.Remove(temp);
                    _userController.Save();
                    LoadDataEatings();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали значение!");
            }
        }
    }
}
