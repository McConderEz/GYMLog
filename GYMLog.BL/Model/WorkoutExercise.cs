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
    public class WorkoutExercise
    {
        [DataMember]
        public Exercise Exercise { get; set; }
        [DataMember]
        public double CaloriesBurned => 10.0 * Duration.TotalMinutes;
        [DataMember]
        public DateTime Date { get; }
        [DataMember]
        public TimeSpan Duration { get; set; }
        [DataMember]
        public int Intensity { get; }
        [DataMember]
        public int Sets { get; set; }
        [DataMember]
        public int Iterations { get; set; }
        [DataMember]
        public double Weight { get; set; }

        [JsonConstructor]
        public WorkoutExercise(int sets,int iterations, double weight, Exercise exercise)
        {
            //TODO: Сделать проверки на аргументы 

            Sets = sets;
            Iterations = iterations;
            Weight = weight;
            Exercise = exercise;
        }

        public override string ToString()
        {
            return $"{Exercise.Name}\nГруппы мышц:{Exercise.Category}\nКол-во повторов:{Iterations}\nКол-во подходов:{Sets}" +
                $"\nВес:{Weight}";
        }
    }
}
