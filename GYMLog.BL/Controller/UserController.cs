using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GYMLog.BL.Controller
{
    public class UserController: ControllerBase
    {
        public List<User> Users { get; }
        public User CurrentUser { get; set; }
        public bool IsNewUser { get; } = false;

        public UserController(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(nameof(login), "Имя пользователя не может быть пустым");
            }

            if(string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(nameof(password), "Пароль не может быть пустым");
            }

            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.Login == login && u.Password == password);

            if(CurrentUser == null)
            {
                CurrentUser = new User(login,password);
                Users.Add(CurrentUser);
                IsNewUser = true;
                Save();
            }

        }

        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileLoadException"></exception>
        private List<User>GetUsersData()
        {
            return Load<User>() ?? new List<User>();
        }

        public void SetNewUserData(string genderName,DateTime birthDate, double weight = 1,double height = 1)
        {
            if (string.IsNullOrWhiteSpace(genderName))
            {
                throw new ArgumentException("Название гендера не может быть пустым!", nameof(genderName));
            }

            if(birthDate.Year < 1900 && birthDate > DateTime.Now)
            {
                throw new ArgumentException("Дата рождения вне допустимых границ!", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Вес пользователя не может быть меньше или равен 0!", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("Рост пользователя не может быть меньше или равен 0!", nameof(height));
            }

            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            Save();
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            Save(Users);
        }
      
    }
}
