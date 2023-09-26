using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    //TODO:Создать модульное тестирование для программ тренировок(Controller)
    //TODO:Сделать сохранение программ в JSON и привязать к пользователям
    //TODO:Создать WorkoutController
    public class Workout
    {
        public List<Exercise> ExerciseList { get; set; }
        public string Day { get; set; }
        /// <summary>
        /// Общее время проведённое за тренировокой 
        /// </summary>
        public double TotalTime => ExerciseList.Sum(x => x.Duration.TotalMinutes);
        /// <summary>
        /// Общее количество сжигаемых калорий за тренировку
        /// </summary>
        public double CaloriesBurned => ExerciseList.Sum(x => x.CaloriesBurned);
        public string Notes { get; set; }


        public Workout(List<Exercise> exercises,string day,string notes = "")
        {
            ExerciseList = new List<Exercise>();
            if(exercises != null)
                ExerciseList.AddRange(exercises);
            if(string.IsNullOrWhiteSpace(day)) throw new ArgumentNullException(nameof(day),"День не может быть пустым!");
            Day = day;
            Notes = notes;
        }

    }
}
