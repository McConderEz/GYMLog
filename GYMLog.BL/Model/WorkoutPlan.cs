﻿using System;
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
        [DataMember]
        public double TotalTime { get; }
        /// <summary>
        /// Общее количество сжигаемых калорий за тренировку
        /// </summary>
        [DataMember]
        public double CaloriesBurned { get; }
        [DataMember]
        public string Notes { get; set; }

        
        public WorkoutPlan(List<WorkoutExercise> exercises,string day,string notes = "")
        {
            ExerciseList = new List<WorkoutExercise>();
            if(exercises != null)
                ExerciseList.AddRange(exercises);
            if(string.IsNullOrWhiteSpace(day)) throw new ArgumentNullException(nameof(day),"День не может быть пустым!");
            Day = day;
            Notes = notes;
        }

        [JsonConstructor]
        public WorkoutPlan(string day, string notes = "")
        {
            
            if (string.IsNullOrWhiteSpace(day)) throw new ArgumentNullException(nameof(day), "День не может быть пустым!");
            Day = day;
            Notes = notes;
            ExerciseList = new List<WorkoutExercise>();
        }

        public override string ToString()
        {
            return $"{Day}\nЗаметки:{Notes}";
        }
    }
}
