using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;




namespace GYMLog.BL.Controller
{

    public class WorkoutPlanController:ControllerBase
    {
        private const string WORKOUT_PLAN_FILE_NAME = "workoutPlan.json";
        private const string EXERCISES_FILE_NAME = "exercises.json";
        private readonly User user;    
        public List<Exercise> Exercises { get; }
        public WorkoutPlan WorkoutPlan { get; set; }

        public bool IsNewWorkoutPlan { get;} = false;


        public WorkoutPlanController(User user) 
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым!", nameof(user));
            Exercises = GetAllExercises();
            this.WorkoutPlan = GetWorkoutPlans();
        }

        public void Add(Exercise exercise, int set, params (double, int)[] setsParams)
        {
            var exerciseTemp = Exercises.SingleOrDefault(x => x.Name.Equals(exercise.Name));
            if (exerciseTemp == null)
            {
                Exercises.Add(exercise);
                WorkoutPlan.AddExercise(new WorkoutExercise(exercise.Name,exercise.Category,set, setsParams));
                Save();
            }
            else
            {
                WorkoutPlan.AddExercise(new WorkoutExercise(exerciseTemp.Name, exerciseTemp.Category, set, setsParams));
                Save();
            }
        }

        private WorkoutPlan? GetWorkoutPlans()
        {
            return Load<WorkoutPlan>(WORKOUT_PLAN_FILE_NAME) ?? new WorkoutPlan(user);
        }

        private List<Exercise>? GetAllExercises()
        {
            return Load<List<Exercise>>(EXERCISES_FILE_NAME) ?? new List<Exercise>();
        }


        public void Save()
        {
            Save(WORKOUT_PLAN_FILE_NAME, WorkoutPlan);
            Save(WORKOUT_PLAN_FILE_NAME, Exercises);
        }


    }
}
