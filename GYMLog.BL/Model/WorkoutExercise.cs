﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace GYMLog.BL.Model
{
    [DataContract]
    [JsonObject]
    public class WorkoutExercise:Exercise
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int WorkoutPlanId { get; set; }
        [DataMember]
        public int Sets { get; set; }
        [DataMember]
        public TimeSpan Duration { get; set; }
        [DataMember]
        public ICollection<ExerciseParams> ExerciseParams { get; set; }



        public WorkoutExercise(string name,string category,double met, int sets, List<ExerciseParams> exerciseParams)
            :base(name, category, met)
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

            if (exerciseParams.Count == 0)
            {
                throw new ArgumentException("Количество повторений не может быть пустым!", nameof(exerciseParams));
            }

            for (var i = 0; i < exerciseParams.Count; i++)
            {
                if(exerciseParams[i].Weight < 0.0 || exerciseParams[i].Iterations < 0)
                {
                    throw new ArgumentException("Ошибка параметров веса или количества повторений", nameof(exerciseParams));
                }
            }
            MET = met;
            Sets = sets;
            ExerciseParams = exerciseParams;
        }

        [Newtonsoft.Json.JsonConstructor]
        public WorkoutExercise(string name,string category,double met)
            :base(name, category, met)
        {

        }

        public WorkoutExercise() { }

        public override string ToString()
        {
            return $"{Name}\tГруппы мышц:{Category}";
        }
    }
}
