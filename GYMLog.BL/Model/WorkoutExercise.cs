using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace GYMLog.BL.Model
{
    [DataContract]
    public class WorkoutExercise:Exercise
    {

        [DataMember]
        public double CaloriesBurned => 10.0 * Duration.TotalMinutes;
        [DataMember]
        public DateTime Date { get; }
        [DataMember]
        public TimeSpan Duration { get; set; }
        [DataMember]
        public int Intensity { get; }
        [DataMember]
        public int Sets { get; set; }
        [DataMember]
        public List<(double,int)> SetsParams { get; set; }
        public object Iterations { get; set; }

        public WorkoutExercise(string name,string category,int sets, params (double,int)[] setsParams)
            :base(name, category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым!",nameof(name));
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentNullException("Категория не может быть пустой", nameof(category));
            }

            if (sets <= 0)
            {
                throw new ArgumentException("Подходы не могут быть меньше или равны 0!", nameof(sets));
            }           

            if (setsParams.Length == 0)
            {
                throw new ArgumentException("Количество повторений не может быть пустым!", nameof(setsParams));
            }

            for (var i = 0; i < setsParams.Length; i++)
            {
                if(setsParams[i].Item1 < 0.0 || setsParams[i].Item2 <= 0)
                {
                    throw new ArgumentException("Ошибка параметров веса или количества повторений", nameof(setsParams));
                }
            }

            Sets = sets;
            SetsParams = setsParams.ToList();
        }

        [JsonConstructor]
        public WorkoutExercise(string name,string category)
            :base(name, category)
        {

        }


        public override string ToString()
        {
            return $"{Name}\nГруппы мышц:{Category}";
        }
    }
}
