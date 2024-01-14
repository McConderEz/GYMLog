using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class SerializableSaver: IDataSaver
    {

        public List<T> Load<T>() where T : class
        {
            var fileName = typeof(T).Name + ".json";

            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                if (!string.IsNullOrEmpty(json))
                {
                    var items = JsonConvert.DeserializeObject<List<T>>(json);
                    if (items != null)
                    {
                        return items;
                    }
                }
            }

            return new List<T>();
        }

        public void Save<T>(List<T> item) where T : class
        {
            var fileName = typeof(T).Name + ".json";

            if (File.Exists(fileName))
            {
                var existingItems = Load<T>();
                existingItems.RemoveAll(_item => item.Any(existingItems => existingItems.Equals(_item)));
                existingItems.AddRange(item);
            }

            var json = JsonConvert.SerializeObject(item, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
