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
        const string CONNECTION_STRING = "data source=(localdb)\\MSSQLLocalDB;Initial Catalog=fitnessDb;Integrated Security=True;";
        readonly StreamWriter logStream = new StreamWriter("log.txt", true);

        public FitnessContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
            optionsBuilder.LogTo(logStream.WriteLine);
        }

        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }

        public DbSet<Eating> Eatings { get; set; }
        public DbSet<WorkoutExercise> Workouts { get; set; }
        public DbSet<ExerciseParams> ExerciseParams { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<WeightedFood> WeightedFoods { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
