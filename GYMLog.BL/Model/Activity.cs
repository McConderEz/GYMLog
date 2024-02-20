using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    [JsonObject]
    public class Activity
    {
        public int Id { get; set; }
        public int WorkoutPlanId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }        
        public virtual WorkoutPlan WorkoutPlan { get; set; }
        public virtual User User { get; set; }

        public double CaloriesBurned { get; set; }
        public DateTime Date { get; set; } 
        public TimeSpan Duration { get; set; } 
        public int Intensity { get; set; }
        public List<WorkoutExercise> CompletedExercises { get; set; }

        [Newtonsoft.Json.JsonConstructor]
        public Activity(string name,User user, WorkoutPlan workoutPlan)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            if(user == null) throw new ArgumentNullException(nameof(user));
            if(workoutPlan == null) throw new ArgumentNullException(nameof(workoutPlan));

            Name = name;
            User = user;
            WorkoutPlan = workoutPlan;  
            CompletedExercises = new List<WorkoutExercise>();
        }

        public Activity() { }

        public void AddCompletedExercises(WorkoutExercise completedExercise)
        {
            if(completedExercise == null) throw new ArgumentNullException();

            CompletedExercises.Add(completedExercise);
        }

    }
}
