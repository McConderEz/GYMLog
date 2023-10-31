using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

//TODO:Протестировать WorkoutPlanController
//TODO:Сделать консольный интерфейс(для начала)
//TODO:Связать иерархию и иметь возможность сохранять Упражнение->Упражнение в плане->План тренировок
//TODO:Поменять iterations из int в массив int(params)


namespace GYMLog.BL.Controller
{
    public class WorkoutPlanController
    {
        public List<WorkoutPlan> workoutPlans { get; }
        public WorkoutPlan currentWorkoutPlan { get; set; }

        public bool IsNewWorkoutPlan { get;} = false;


        public WorkoutPlanController(string day) 
        {
            if (string.IsNullOrWhiteSpace(day))
            {
                throw new ArgumentNullException("День не может быть null!", nameof(day));
            }

            workoutPlans = GetPlansDate();

            currentWorkoutPlan = workoutPlans.SingleOrDefault(x => x.Day == day);

            if(currentWorkoutPlan == null)
            {
                currentWorkoutPlan = new WorkoutPlan(day);
                workoutPlans.Add(currentWorkoutPlan);
                IsNewWorkoutPlan = true;
                Save();
            }

        }

        private void Save()
        {
            using(var fs = new FileStream("workoutPlans.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, workoutPlans);
            }
        }

        public List<WorkoutPlan> GetPlansDate()
        {
            using(var fs = new FileStream("workoutPlans.json", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && JsonSerializer.Deserialize<List<WorkoutPlan>>(fs) is List<WorkoutPlan> workoutPlans)
                {
                    return workoutPlans;
                }
                else
                {
                    return new List<WorkoutPlan>();
                }
            }
        }

    }
}
