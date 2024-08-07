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
    public class WeightedFood
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int FoodId { get; set; } 
        [DataMember]
        public virtual Food Food { get; set; }
        [DataMember]
        public double Weight { get; set; }
        public int EatingId { get; set; }
        public virtual Eating Eating { get; set; }

        [Newtonsoft.Json.JsonConstructor]
        public WeightedFood(Food food, double weight)
        {
            Food = food;
            Weight = weight;
        }

        public WeightedFood() { }

    }
}
