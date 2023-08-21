using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    public class User
    {
        #region Свойства
        public string Login { get; }
        public Gender Gender { get; }
        public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        #endregion

        public User(string login, 
            Gender gender, 
            DateTime birthDate, 
            double weight, 
            double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(login));
            }

            if(Gender == null)
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
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight; 
            Height = height;

        }

        public override string ToString()
        {
            return Login;
        }
    }
}
