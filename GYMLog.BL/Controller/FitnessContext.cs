using GYMLog.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    public class FitnessContext: DbContext
    {
        //TODO:Протестировать создание дб
        //TODO:Протестировать сохранение и загрузку данных из дб
        const string CONNECTION_STRING = "data source=(localdb)\\MSSQLLocalDB;Initial Catalog=fitnessDb;Integrated Security=True;\" providerName=\"System.Data.SqlClient\"";

        public FitnessContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        public DbSet<Eating> Eatings { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutExercise> Workouts { get; set; }
        public DbSet<ExerciseParams> ExerciseParams { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<WeightedFood> WeightedFoods { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
