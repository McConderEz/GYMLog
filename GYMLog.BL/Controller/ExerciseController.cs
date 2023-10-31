using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GYMLog.BL.Controller
{
    public class ExerciseController
    {
        public List<Exercise> Exercises { get; }
        public Exercise CurrentExercise { get; set; }
        public bool IsNewExercise { get; } = false;

        public ExerciseController(string name, string category)
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

            if(CurrentExercise == null)
            {
                CurrentExercise = new Exercise(name, category); 
                Exercises.Add(CurrentExercise);
                IsNewExercise = true;
                Save();
            }

        }

        public void Save()
        {

            using (var fs = new FileStream("exercises.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, Exercises);
            }
        }

        /// <summary>
        /// Возвращаем данные о упражнениях сохраненные в JSON, если они существуют
        /// </summary>
        /// <returns></returns>
        private List<Exercise> GetExercisesDate()
        {
            using(var fs = new FileStream("exercises.json", FileMode.OpenOrCreate))
            {
                if(fs.Length > 0 && JsonSerializer.Deserialize<List<Exercise>>(fs) is List<Exercise> exercises)
                {
                    return exercises;
                }
                else
                {
                    return new List<Exercise>();
                }
            }
        }

        public void SetNewExerciseData(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException("Описание не может быть равно null", nameof(description));
            }
            CurrentExercise.Description = description;
            Save();
        }
    }
}
