using GYMLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    /// <summary>
    /// Приём пищи
    /// </summary>

    [DataContract]
    public class Eating
    {
        [DataMember]
        public DateTime Moment { get; }

        [DataMember]
        public List<WeightedFood> Foods { get; set; }

        [DataMember]
        public User User { get; }

        [JsonConstructor]
        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.",nameof(user));
            Moment = DateTime.UtcNow;
            Foods = new List<WeightedFood>();

        }

        public void Add(Food food, double weight)
        {
            var product = Foods.FirstOrDefault(x => x.Food.Name.Equals(food.Name));

            if (product == null)
            {
                Foods.Add(new WeightedFood(food, weight));
            }
            else
            {
                product.Weight += weight;
            }
        }
    }
}
