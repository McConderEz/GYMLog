using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GYMLog.BL.Controller
{
    public abstract class ControllerBase
    {
        protected void Save(string fileName,object item)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                
                JsonSerializer.Serialize(fs, item);
                
            }
        }        

        //protected void Save(string fileName, object item, JsonSerializerOptions options)
        //{
        //    using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
        //    {
        //        JsonSerializer.Serialize(fs, item, options);
        //    }
        //}

        protected T Load<T>(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && JsonSerializer.Deserialize<T>(fs) is T items)
                {
                    return items;
                }
                else
                {
                    return default(T);
                }
            }
        }

        //protected T Load<T>(string fileName, JsonSerializerOptions options)
        //{
        //    using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
        //    {
        //        if (fs.Length > 0 && JsonSerializer.Deserialize<T>(fs,options) is T items)
        //        {
        //            return items;
        //        }
        //        else
        //        {
        //            return default(T);
        //        }
        //    }
        //}

    }
}
