﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    [DataContract]
    [JsonObject]
    public class User
    {
        #region Свойства
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int? GenderId { get; set; }
        [DataMember]
        public virtual Gender Gender { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public double Height { get; set; }
        [DataMember]
        public virtual ICollection<WorkoutPlan> WorkoutPlans { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Activity> Activities { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Eating> Eatings { get; set; }

        public int Age => DateTime.Now.Year - BirthDate.Year;
        #endregion



        public User(string login, 
            string password,
            Gender gender, 
            DateTime birthDate, 
            double weight, 
            double height,
            List<WorkoutPlan>? workoutPlans = null, List<Activity> activities = null, List<Eating> eatings = null)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(login));
            }

            if(string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                throw new ArgumentException("Пароль не может быть пустым или null, а также быть короче 8ми символом", nameof(password));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Гендер не может быть null",nameof(gender));
            }

            if(birthDate < DateTime.Parse("01.01.1910") && birthDate >= DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Выход за границы допустимых значений",nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentOutOfRangeException("Выход за границы допустимых значений", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentOutOfRangeException("Выход за границы допустимых значений", nameof(height));
            }
            #endregion

            Login = login;
            Password = password;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight; 
            Height = height;
            if (workoutPlans != null)
            {
                WorkoutPlans = workoutPlans;
            }
            else
            {
                WorkoutPlans = new List<WorkoutPlan>();
            }
            Activities = Activities ?? new List<Activity>();
            Eatings = Eatings ?? new List<Eating>();
        }

        [Newtonsoft.Json.JsonConstructor]
        public User(string login,string password)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(login));
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                throw new ArgumentException("Пароль не может быть пустым или null, а также быть короче 8ми символом", nameof(password));
            }

            Login = login;
            Password = password;
            WorkoutPlans = new List<WorkoutPlan>();
            Activities = Activities ?? new List<Activity>();
            Eatings = Eatings ?? new List<Eating>();
        }

        
        public User() { }

        public override string ToString()
        {
            return Login + " " + Age;
        }
    }
}
