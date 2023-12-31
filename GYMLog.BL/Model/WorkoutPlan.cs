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
        public string PlanName { get; set; }

        [DataMember]
        public DateTime Moment { get; }
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

        [DataMember]
        public User User { get; }
        
        public WorkoutPlan(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.", nameof(user));
            Moment = DateTime.UtcNow;
            ExerciseList = new List<WorkoutExercise>();
        }

        [JsonConstructor]
        public WorkoutPlan(string planName, string notes = "")
        {         
            if (string.IsNullOrWhiteSpace(planName)) throw new ArgumentNullException(nameof(planName), "Название программы тренировок не может быть пустым!");
            PlanName = planName;
            Notes = notes;
            ExerciseList = new List<WorkoutExercise>();
        }

        public void AddExercise(WorkoutExercise exercise)
        {
            var existingExercise = ExerciseList.SingleOrDefault(x => x.Name.Equals(exercise.Name));

            if (existingExercise == null)
            {
                ExerciseList.Add(exercise);
            }
            else
            {
                existingExercise.Sets += exercise.Sets;
                existingExercise.SetsParams.AddRange(exercise.SetsParams);
            }

        }

        public override string ToString()
        {
            return $"{PlanName}\nЗаметки:{Notes}";
        }
    }
}
