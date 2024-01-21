
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Model
{
 
    [DataContract]
    [JsonObject]
    public class Exercise
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Description { get; set; }
        
        
        public Exercise(string name,string category,string description)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name),"Имя не может быть пустым!");
            if (string.IsNullOrWhiteSpace(category)) throw new ArgumentNullException(nameof(category), "Категория упражнения не может быть пустой!");
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException(nameof(description), "Описание не может быть пустым!");
            
            Name = name;
            Category = category;
            Description = description;
           
        }

        [Newtonsoft.Json.JsonConstructor]
        public Exercise(string name,string category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя упражнения не может быть пустым", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentNullException("Категория упражнения не может быть пуста", nameof(category));
            }

            Name = name;
            Category = category;
        }

        public Exercise() { }
    }
}
