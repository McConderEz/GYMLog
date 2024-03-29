﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    [DataContract]
    [JsonObject]
    public class Gender
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [Newtonsoft.Json.JsonConstructor]
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
