using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class DatabaseSaver: IDataSaver
    {
        //TODO:Написать CRUDы
        public List<T> Load<T>() where T : class
        {
            using (var db = new FitnessContext())
            {
                var result = db.Set<T>().Where(t => true).ToList();
                return result;
            }
        }

        public void Save<T>(List<T> items) where T : class
        {
            using (var db = new FitnessContext())
            {
                foreach(var item in items)
                {
                    var entry = db.Entry(item);

                    if(entry.State == EntityState.Detached)
                    {
                        db.Set<T>().Add(item);
                    }
                    else
                    {
                        entry.State = EntityState.Modified;
                        db.Set<T>().Update(item);
                    }
                }
                //db.Set<T>().AddRange(items);                
                db.SaveChanges();
            }
        }
    }
}
