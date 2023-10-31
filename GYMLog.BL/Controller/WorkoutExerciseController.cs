using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class WorkoutExerciseController
    {
        public List<WorkoutExercise> Exercises { get; }
        public WorkoutExercise CurrentExercise { get; set; }
        public bool IsNewExercise { get; } = false;

        public WorkoutExerciseController(string name, string category, int sets, double weights, params int[] iterations)
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
                CurrentExercise = new WorkoutExercise(name, category,sets,weights,iterations);
                Exercises.Add(CurrentExercise);
                IsNewExercise = true;
                Save();
            }

        }

        public void Save()
        {

            using (var fs = new FileStream("workoutExercises.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, Exercises);
            }
        }

        /// <summary>
        /// Возвращаем данные о упражнениях сохраненные в JSON, если они существуют
        /// </summary>
        /// <returns></returns>
        private List<WorkoutExercise> GetExercisesDate()
        {
            using (var fs = new FileStream("workoutExercises.json", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && JsonSerializer.Deserialize<List<WorkoutExercise>>(fs) is List<WorkoutExercise> exercises)
                {
                    return exercises;
                }
                else
                {
                    return new List<WorkoutExercise>();
                }
            }
        }

        
        public void SetNewExerciseData(string description, int sets, double weights, params int[] iterations)
        {
            //TODO:Проверка
            CurrentExercise.Description = description;
            CurrentExercise.Sets = sets;
            CurrentExercise.Weight = weights;
            CurrentExercise.Iterations = iterations;
        }
    }
}
