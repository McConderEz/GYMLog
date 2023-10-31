using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{

    [DataContract]
    public class WorkoutPlan
    {
        [DataMember]
        public List<WorkoutExercise> ExerciseList { get; set; }
        [DataMember]    
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

        [JsonConstructor]
        public WorkoutPlan(List<WorkoutExercise> exercises,string day,string notes = "")
        {
            ExerciseList = new List<WorkoutExercise>();
            if(exercises != null)
                ExerciseList.AddRange(exercises);
            if(string.IsNullOrWhiteSpace(day)) throw new ArgumentNullException(nameof(day),"День не может быть пустым!");
            Day = day;
            Notes = notes;
        }

        public WorkoutPlan(string day, string notes = "")
        {
            
            if (string.IsNullOrWhiteSpace(day)) throw new ArgumentNullException(nameof(day), "День не может быть пустым!");
            Day = day;
            Notes = notes;
        }

        public override string ToString()
        {
            return $"{Day}\nЗаметки:{Notes}";
        }
    }
}
