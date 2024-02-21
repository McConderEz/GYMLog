using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Helper
{
    /// <summary>
    /// Класс для парсинга датасета с упражнениями
    /// </summary>
    public static class ParserCSV
    {
        public static List<Exercise> LoadExercises(string path)
        {
            List<Exercise> exercises = new List<Exercise>();
            using(var sr = new StreamReader(path))
            {
                var header = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    var row = sr.ReadLine();
                    var values = row.Split(';');

                    exercises.Add(new Exercise
                    {
                        Name = values[0],
                        Category = values[1],
                        MET = double.Parse(values[2])
                    });
                }
            }
            return exercises;
        }
    }
}
