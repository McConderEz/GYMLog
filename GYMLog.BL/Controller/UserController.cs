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
    public class UserController
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
        private List<User >GetUsersData()
        {
            
            using (var fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                if (JsonSerializer.Deserialize<List<User>>(fs) is List<User> users)
                {
                    return users;
                }
                else
                {
                    return new List<User>();
                }
            }
        }

        public void SetNewUserData(string genderName,DateTime birthDate, double weight = 1,double height = 1)
        {
            //TODO:Проверка
            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        private void Save()
        {

            using (var fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, Users);
            }
        }

        
    }
}
