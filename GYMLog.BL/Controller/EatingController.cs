using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class EatingController:ControllerBase
    {

        public UserController userController;
        public List<Food> Foods { get; }
        public Eating Eating { get; }

        public event EventHandler EatingAdded;

        public EatingController(UserController userController)
        {
            this.userController = userController ?? throw new ArgumentNullException("Пользователь не может быть пустым!",nameof(userController));

            Foods = GetAllFoods();
            Eating = GetEating();

        }

      
        public void Add(Food food, double weight)
        {
            var product = Foods.SingleOrDefault(x => x.Name == food.Name);
            if(product == null)
            {
                Foods.Add(food);
                Eating.Add(food, weight);
                userController.CurrentUser.Eatings.Add(Eating);
                Save();
            }
            else
            {
                Eating.Add(product,weight);
                userController.CurrentUser.Eatings.Add(Eating);
                Save();
            }
            userController.Save();
            EatingAdded?.Invoke(this, EventArgs.Empty);
        }

        private Eating GetEating()
        {
            return Load<Eating>().FirstOrDefault() ?? new Eating(userController.CurrentUser);
        }


        private List<Food> GetAllFoods()
        {
            return Load<Food>() ?? new List<Food>();
        }

        

        public void Save()
        {
            Save(Foods);
            Save(new List<Eating>() { Eating });
        }
      
    }
}
