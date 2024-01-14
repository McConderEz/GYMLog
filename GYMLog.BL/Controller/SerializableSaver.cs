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
        //TODO: Переписать в Newtonsoft.JSON
        //TODO: Протестировать сохранение и загрузку данных из JSON файлов
        public List<T> Load<T>() where T : class
        {
            var fileName = typeof(T).Name + ".json";

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && JsonSerializer.Deserialize<T>(fs) is List<T> items)
                {
                    return items;
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        public void Save<T>(List<T> item) where T : class
        {
            var fileName = typeof(T).Name + ".json";

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var option = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(fs, item,option);
            }
        }
    }
}
