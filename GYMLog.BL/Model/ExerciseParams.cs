
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    [DataContract]
    [JsonObject]
    public class ExerciseParams
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Iterations { get; set; }
        [DataMember]
        public double Weight { get; set; }
        public int WorkoutExerciseId { get; set; }
        public virtual WorkoutExercise WorkoutExercise { get; set; }

        [Newtonsoft.Json.JsonConstructor]
        public ExerciseParams(int iterations, double weight)
        {
            if(iterations < 0)
            {
                throw new ArgumentException("Количество итераций не может быть меньше 0!", nameof(iterations));
            }

            if(weight < 0)
            {
                throw new ArgumentException("Вес не может быть отрицательным", nameof(weight));
            }

            Iterations = iterations;
            Weight = weight;
        }

        public ExerciseParams() { }
    }
}
