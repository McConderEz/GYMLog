using GYMLog.BL.Controller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    [JsonObject]
    public class Eating
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Moment { get; set; }

        [DataMember]
        public ICollection<WeightedFood> Foods { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public virtual User User { get; set; }

        [Newtonsoft.Json.JsonConstructor]
        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.",nameof(user));
            Moment = DateTime.UtcNow;
            Foods = new List<WeightedFood>();

        }

        public Eating() { }

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
