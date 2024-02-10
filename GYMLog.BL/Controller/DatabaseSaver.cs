using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class DatabaseSaver: IDataSaver
    {
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
                db.Set<T>().UpdateRange(items); //Замена AddRange на UpdateRange с целью добавлять новые записи и обновлять старые без конфликта вставки Id
                db.SaveChanges();               //Возможно, неоптимальное решение
            }
        }
    }
}
