﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    [DataContract]
    [JsonObject]
    public class Food
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Белки
        /// </summary>
        [DataMember]
        public double Proteins { get; set; }

        /// <summary>
        /// Жиры
        /// </summary>
        [DataMember]
        public double Fats { get; set; }

        /// <summary>
        /// Углеводы
        /// </summary>
        [DataMember]
        public double Carbohydrates { get; set; }

        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>
        [DataMember]
        public double Calories { get; set; }

        /// <summary>
        /// Калории за 1 грамм продукта
        /// </summary>
        [DataMember]
        public double CaloriesOneGramm { get => Calories / 100.0; }
        [DataMember]
        public double ProteinsOneGramm { get => Proteins / 100.0; }
        [DataMember]
        public double FatsOneGramm { get => Fats / 100.0; }
        [DataMember]
        public double CarbohydratesOneGramm { get => Carbohydrates / 100.0; }

        public virtual ICollection<Eating> Eatings { get; set; }
        
        public Food(string name) : this(name, 0, 0, 0, 0) { }

        [Newtonsoft.Json.JsonConstructor]
        public Food(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя продукта не может быть пустым!", nameof(name));
            }

            if(proteins < 0)
            {
                throw new ArgumentException("Количество белков не может быть меньше 0!", nameof(proteins));
            }

            if(fats < 0)
            {
                throw new ArgumentException("Количество жиров не может быть меньше 0!", nameof(fats));
            }

            if (carbohydrates < 0)
            {
                throw new ArgumentException("Количество углеводов не может быть меньше 0!", nameof(carbohydrates));
            }

            if(calories < 0)
            {
                throw new ArgumentException("Количество калорий не можеть быть меньше 0!", nameof(calories));
            }
            Name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Calories = calories;
        }

        public Food() { }
        public override string ToString()
        {
            return Name;
        }
    }
}
