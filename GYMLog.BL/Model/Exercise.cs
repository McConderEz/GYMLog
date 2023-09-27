using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    //TODO:Создать модульное тестирование для упражнений(Controller)
    //TODO:Сделать сохранение упражнений в JSON и привязать в программе тренировок
    //TODO:Создать ExerciseController
    [DataContract]
    public class Exercise
    {
        [DataMember]
        public string Name { get; }
        [DataMember]
        public string Category { get; }
        [DataMember]
        public string Description { get; set; }

        //TODO:Перенести это всё в новый класс WorkoutExercise
        public double CaloriesBurned => 10.0 * Duration.TotalMinutes;
        public DateTime Date { get; }
        public TimeSpan Duration { get; set; }
        public int Intensity { get; }
        public int Sets { get; set; }
        public int Iterations { get; set; }
        public double Weight { get; set; }
        
        public Exercise(string name,string category,string description,
            int sets,int iterations, double weight = 0.0)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name),"Имя не может быть пустым!");
            if (string.IsNullOrWhiteSpace(category)) throw new ArgumentNullException(nameof(category), "Категория упражнения не может быть пустой!");
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException(nameof(description), "Описание не может быть пустым!");
            if (sets <= 0 && sets > 50) throw new ArgumentOutOfRangeException(nameof(sets), "Количество подходов вне допустимых границ!");
            if (iterations <= 0 && iterations > 10000) throw new ArgumentOutOfRangeException(nameof(iterations), "Количество повторений вне допустимых границ!");
            if (weight < 0 || weight > 2000) throw new ArgumentOutOfRangeException(nameof(weight), "Значение веса выходит за допустимые границы");

            Name = name;
            Category = category;
            Description = description;
            Sets = sets;
            Iterations = iterations;
            Weight = weight;
        }

        [JsonConstructor]
        public Exercise(string name,string category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя упражнения не может быть пустым", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentNullException("Категория упражнения не может быть пуста", nameof(category));
            }

            Name = name;
            Category = category;
        }

    }
}
