using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    public class Exercise
    {
        public string Name { get; }
        public string Category { get; }
        public string Description { get; }
        //TODO:Предварительный расчёт сжигаемых калрий за тренировку
        public double CaloriesBurned => 10.0 * Duration.TotalMinutes;
        public DateTime Date { get; }
        public TimeSpan Duration { get; set; }
        public int Intensity { get; }
        public int Sets { get; set; }
        public int Iterations { get; set; }
        
        public Exercise(string name,string category,string description,
            int sets,int iterations)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name),"Имя не может быть пустым!");
            if (string.IsNullOrWhiteSpace(category)) throw new ArgumentNullException(nameof(category), "Категория упражнения не может быть пустой!");
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException(nameof(description), "Описание не может быть пустым!");
            if (sets <= 0 && sets > 50) throw new ArgumentOutOfRangeException(nameof(sets), "Количество подходов вне допустимых границ!");
            if (iterations <= 0 && iterations > 10000) throw new ArgumentOutOfRangeException(nameof(iterations), "Количество повторений вне допустимых границ!");

            Name = name;
            Category = category;
            Description = description;
            Sets = sets;
            Iterations = iterations;
        }

    }
}
