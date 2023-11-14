using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    [DataContract]
    public class WeightedFood
    {
        [DataMember]
        public Food Food { get; set; }
        [DataMember]
        public double Weight { get; set; }

        [JsonConstructor]
        public WeightedFood(Food food, double weight)
        {
            Food = food;
            Weight = weight;
        }

    }
}
