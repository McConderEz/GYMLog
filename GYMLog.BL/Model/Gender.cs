using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    [DataContract]
    public class Gender
    {
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        [DataMember]
        public string Name { get; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя поля не может быть пустым или null", nameof(name));
            }

            Name = name;
        }

        public Gender() { }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
