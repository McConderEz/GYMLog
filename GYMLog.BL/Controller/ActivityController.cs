using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class ActivityController: ControllerBase
    {
        //TODO: Сделать интерфейс для проведения тренировки

        public Activity CurrentActivity { get; set; }
        public UserController userController;
        public List<Activity> Activities { get; set; }

        public event EventHandler ActivityStarted;
        public event EventHandler ActivityStopped;
        public event EventHandler ExerciseStarted;
        public event EventHandler ExerciseStoppped;

        private WorkoutExercise _currentExercise;

        public ActivityController(User user)
        {
            userController = new UserController(user.Login, user.Password);
            Activities = GetAllActivities();
        }

        public void Start(WorkoutPlan workoutPlan)
        {
            if(workoutPlan == null) throw new ArgumentNullException(nameof(workoutPlan));

            CurrentActivity = new Activity(workoutPlan.PlanName, userController.CurrentUser, workoutPlan);

            if(userController.CurrentUser.Activities == null)
            {
                userController.CurrentUser.Activities = new List<Activity>();   
            }

            userController.CurrentUser.Activities.Add(CurrentActivity);
            CurrentActivity.Date = DateTime.Now;

            ActivityStarted?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            CurrentActivity.Duration = (DateTime.Now.TimeOfDay - CurrentActivity.Date.TimeOfDay);
            ActivityStopped?.Invoke(this, EventArgs.Empty);
            GetStatistic();
        }

        public void StartExercise(WorkoutExercise exercise)
        {
            if(exercise == null) throw new ArgumentNullException(nameof(exercise)); 

            _currentExercise = exercise;
            _currentExercise.Duration = DateTime.Now.TimeOfDay;

            ExerciseStarted?.Invoke(this, EventArgs.Empty);
        }

        public void StopExercise()
        {
            _currentExercise.Duration = DateTime.Now.TimeOfDay - _currentExercise.Duration;

            ExerciseStoppped?.Invoke(this, EventArgs.Empty);
        }

        private void GetStatistic()
        {
            CalcBurnedCalories();
        }

        private void CalcBurnedCalories()
        {
            foreach(var exercise in CurrentActivity.CompletedExercises)
            {
                CurrentActivity.CaloriesBurned += (exercise.MET * userController.CurrentUser.Weight * exercise.Duration.TotalMinutes) / 60.0;
            }
        }

        public void SetIntensity(int intensityLevel)
        {
            if(intensityLevel < 0) throw new ArgumentOutOfRangeException(nameof(intensityLevel));

            CurrentActivity.Intensity = intensityLevel;
        }

        private List<Activity> GetAllActivities()
        {
            return Load<Activity>() ?? new List<Activity>();
        }

        public void Save()
        {
            Save(new List<Activity>() { CurrentActivity });
        }
    }
}
