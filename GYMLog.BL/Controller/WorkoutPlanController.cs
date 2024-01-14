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

        public void Add(Exercise exercise, int set, List<ExerciseParams> exerciseParams)
        {
            var exerciseTemp = Exercises.SingleOrDefault(x => x.Name.Equals(exercise.Name));
            if (exerciseTemp == null)
            {
                Exercises.Add(exercise);
                WorkoutPlan.AddExercise(new WorkoutExercise(exercise.Name,exercise.Category,set, exerciseParams));
                Save();
            }
            else
            {
                WorkoutPlan.AddExercise(new WorkoutExercise(exerciseTemp.Name, exerciseTemp.Category, set, exerciseParams));
                Save();
            }
        }

        public void SetNewWorkoutPlanData(string planName,string notes = "")
        {
            if (string.IsNullOrWhiteSpace(planName))
            {
                throw new ArgumentNullException("Название плана тренировок не может быть пустым!", nameof(planName));
            }
            WorkoutPlan.PlanName = planName;
            WorkoutPlan.Notes = notes;
            Save();
        }

        private WorkoutPlan? GetWorkoutPlans()
        {
            return Load<WorkoutPlan>().FirstOrDefault() ?? new WorkoutPlan(user);
        }

        private List<Exercise>? GetAllExercises()
        {
            return Load<Exercise>() ?? new List<Exercise>();
        }


        public void Save()
        {
            Save(new List<WorkoutPlan>() { WorkoutPlan }); 
            Save(Exercises);
        }


    }
}
