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
        public User User { get; }

        public UserController(string userName, string password, string genderName, DateTime birthDay,double weight, double height)
        {
            //TODO: Провкар
            var gender = new Gender(genderName);
            var user = new User(userName, password, gender, birthDay, weight, height); 
            User = user;
        }

        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileLoadException"></exception>
        public UserController()
        {
            
            using (var fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                if (JsonSerializer.Deserialize<User>(fs) is User user)
                {
                    User = user;
                }

                //TODO: Что делать, если пользователя не прочитали
            }
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {

            using (var fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, User);
            }
        }

        
    }
}
