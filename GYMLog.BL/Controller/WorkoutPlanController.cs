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

    public class WorkoutPlanController:ControllerBase, ICrudController<WorkoutPlan>
    {
        private User _user;
        public UserController userController;
        public List<Exercise> Exercises { get; }
        public WorkoutPlan WorkoutPlan { get; set; }

        public bool IsNewWorkoutPlan { get;} = false;

        public event EventHandler WorkoutPlanChanged;

        //TODO: Переписать модель WorkoutPlanController(когда-нибудь при необходимости)

        public WorkoutPlanController(User user) 
        {
            this._user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым!", nameof(user));
            userController = new UserController(_user.Login, _user.Password);
            Exercises = GetAllExercises();
            this.WorkoutPlan = GetWorkoutPlans();
        }

        //TODO:Сделать сохранение изменений
        public void Add(Exercise exercise, int set, List<ExerciseParams> exerciseParams)
        {
            var exerciseTemp = Exercises.SingleOrDefault(x => x.Name.Equals(exercise.Name));
            if (exerciseTemp == null)
            {
                Exercises.Add(exercise);
                userController.CurrentUser.WorkoutPlans.ElementAt(WorkoutPlan.Id).AddExercise(new WorkoutExercise(exercise.Name, exercise.Category, set, exerciseParams));
                userController.Save();
                Save();               
            }
            else
            {
                userController.CurrentUser.WorkoutPlans.ElementAt(WorkoutPlan.Id).AddExercise(new WorkoutExercise(exercise.Name, exercise.Category, set, exerciseParams));
                userController.Save();
                Save();               
            }

            WorkoutPlanChanged?.Invoke(this,EventArgs.Empty);
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
            return Load<WorkoutPlan>().FirstOrDefault() ?? new WorkoutPlan(_user);
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

        public void Add(WorkoutPlan item)
        {
            WorkoutPlan = item;
            userController.CurrentUser.WorkoutPlans.Add(item);
            SetNewWorkoutPlanData(item.PlanName, item.Notes);
            userController.Save();
            WorkoutPlanChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Update(WorkoutPlan item)
        {
            WorkoutPlan = item;
            var _item = userController.CurrentUser.WorkoutPlans.FirstOrDefault(x => x == item);
            _item = item;
            userController.Save();
            WorkoutPlanChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Delete(int index)
        {
            var item = userController.CurrentUser.WorkoutPlans.ElementAt(index);
            userController.CurrentUser.WorkoutPlans.Remove(item);  
            userController.Save();
            Save();
            WorkoutPlanChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
