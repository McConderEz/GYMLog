using GYMLog.BL.Helper;
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
    public class ExerciseController:ControllerBase
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
                CurrentExercise = new Exercise(name, category, 1); 
                Exercises.Add(CurrentExercise);
                IsNewExercise = true;
                Save();
            }

        }

        public ExerciseController()
        {
            Exercises = GetExercisesDate();

            if (Exercises.Count == 0)
                Exercises.AddRange(ParserCSV.LoadExercises("C:\\Users\\rusta\\Source\\Repos\\GYMLog\\GYMLog.BL\\Dataset\\Exercises.csv"));

            Save();
        }

        public void Save()
        {
            Save(Exercises);
        }

        /// <summary>
        /// Возвращаем данные о упражнениях сохраненные в JSON, если они существуют
        /// </summary>
        /// <returns></returns>
        private List<Exercise> GetExercisesDate()
        {
            return Load<Exercise>() ?? new List<Exercise>();
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
