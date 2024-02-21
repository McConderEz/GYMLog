using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class WorkoutExerciseController:ControllerBase
    {
        public List<WorkoutExercise> Exercises { get; }
        public WorkoutExercise CurrentExercise { get; set; }
        public bool IsNewExercise { get; } = false;

        public WorkoutExerciseController(string name, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя упражнения не может быть пустым", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentNullException("Категория упражнения не может быть пуста", nameof(category));
            }

            Exercises = GetExercisesDate();

            CurrentExercise = Exercises.SingleOrDefault(u => u.Name.ToLower() == name.ToLower() && u.Category.ToLower() == category.ToLower());

            if (CurrentExercise == null)
            {
                CurrentExercise = new WorkoutExercise(name, category, 1);
                Exercises.Add(CurrentExercise);
                IsNewExercise = true;
            }

        }

        public void Save()
        {
            Save(Exercises);
        }

        /// <summary>
        /// Возвращаем данные о упражнениях сохраненные в JSON, если они существуют
        /// </summary>
        /// <returns></returns>
        private List<WorkoutExercise> GetExercisesDate()
        {
            return Load<WorkoutExercise>() ?? new List<WorkoutExercise>();           
        }

        
        public void SetNewExerciseData(string description, int sets,List<ExerciseParams> exerciseParams)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException("Описание не может быть равно null", nameof(description));
            }

            if(sets <= 0)
            {
                throw new ArgumentException("Подходы не могут быть меньше или равны 0!", nameof(sets));
            }

            if (exerciseParams.Count == 0)
            {
                throw new ArgumentException("Количество повторений не может быть пустым!", nameof(exerciseParams));
            }

            for (var i = 0; i < exerciseParams.Count; i++)
            {
                if (exerciseParams[i].Weight < 0.0 || exerciseParams[i].Iterations < 0)
                {
                    throw new ArgumentException("Ошибка параметров веса или количества повторений", nameof(exerciseParams));
                }
            }

            

            CurrentExercise.Description = description;
            CurrentExercise.Sets = sets;
            CurrentExercise.ExerciseParams = exerciseParams;
            Save();
        }
    }
}
