using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYMLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMLog.BL.Model;

namespace GYMLog.BL.Controller.Tests
{
    [TestClass()]
    public class WorkoutExerciseControllerTests
    {
        
        [TestMethod()]
        public void SetNewExerciseDataTest()
        {
            Random rand = new Random();
            var name = Guid.NewGuid().ToString();
            var category = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();

            var sets = 3;


            WorkoutExerciseController controller = new WorkoutExerciseController(name, category);

            List<ExerciseParams> exerciseParams = new List<ExerciseParams>
            {
                new ExerciseParams(1,5),
                new ExerciseParams(4,1),
                new ExerciseParams(2,4)
            };

            controller.SetNewExerciseData(description, sets, exerciseParams);

            WorkoutExerciseController controller2 = new WorkoutExerciseController(name, category);

            Assert.AreEqual(name, controller2.CurrentExercise.Name);
            Assert.AreEqual(category, controller2.CurrentExercise.Category);
            Assert.AreEqual(description, controller2.CurrentExercise.Description);
            Assert.AreEqual(sets, controller2.CurrentExercise.Sets);
            for (var i = 0; i < sets; i++)
            {
                Assert.AreEqual(exerciseParams[i].Iterations, controller2.CurrentExercise.ExerciseParams[i].Iterations);
                Assert.AreEqual(exerciseParams[i].Weight, controller2.CurrentExercise.ExerciseParams[i].Weight);
            }

        }

        [TestMethod()]
        public void SaveTest()
        {
            var name = Guid.NewGuid().ToString();
            var category = Guid.NewGuid().ToString();

            WorkoutExerciseController controller = new WorkoutExerciseController(name,category);

            Assert.AreEqual(name, controller.CurrentExercise.Name);
            Assert.AreEqual(category, controller.CurrentExercise.Category);
        }
    }
}