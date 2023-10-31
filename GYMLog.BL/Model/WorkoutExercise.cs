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
    public class WorkoutExercise:Exercise
    {

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
        public int[] Iterations { get; set; }
        [DataMember]
        public double Weight { get; set; }

        
        public WorkoutExercise(string name,string category,int sets, double weight, params int[] iterations)
            :base(name, category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым!",nameof(name));
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentNullException("Категория не может быть пустой", nameof(category));
            }

            if (sets <= 0)
            {
                throw new ArgumentException("Подходы не могут быть меньше или равны 0!", nameof(sets));
            }

            if (weight < 0)
            {
                throw new ArgumentException("Вес не может быть меньше 0!", nameof(weight));
            }

            if (iterations.Length == 0)
            {
                throw new ArgumentException("Количество повторений не может быть пустым!", nameof(iterations));
            }

            for (var i = 0; i < iterations.Length; i++)
            {
                if (iterations[i] <= 0)
                {
                    throw new ArgumentException("Количество повторений меньше или равно 0!", nameof(iterations));
                }
            }

            Sets = sets;
            Iterations = iterations;
            Weight = weight;
        }

        [JsonConstructor]
        public WorkoutExercise(string name,string category)
            :base(name, category)
        {

        }


        public override string ToString()
        {
            return $"{Name}\nГруппы мышц:{Category}\nКол-во повторов:{Iterations}\nКол-во подходов:{Sets}" +
                $"\nВес:{Weight}";
        }
    }
}
