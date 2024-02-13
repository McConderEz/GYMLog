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

        private readonly User user;
        public List<Food> Foods { get; }
        public Eating Eating { get; }

        public EatingController(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым!",nameof(user));

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
                Save();
            }
            else
            {
                Eating.Add(product,weight);
                Save();
            }
        }

        private Eating GetEating()
        {
            return Load<Eating>().FirstOrDefault() ?? new Eating(user);
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
