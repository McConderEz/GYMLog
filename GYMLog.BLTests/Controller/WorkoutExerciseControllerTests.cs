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
        //TODO:Протестировать изменения
        [TestMethod()]
        public void SetNewExerciseDataTest()
        {
            //Random rand = new Random();
            //var name = Guid.NewGuid().ToString();
            //var category = Guid.NewGuid().ToString();
            //var description = Guid.NewGuid().ToString();

            //var sets = rand.Next(1, 10);
            //var weight = rand.Next(0, 100);
            //int[] iterations = new int[sets];

            //for (var i = 0; i < sets; i++) { iterations[i] = rand.Next(1, 100); }

            //WorkoutExerciseController controller = new WorkoutExerciseController(name, category);

            //controller.SetNewExerciseData(description, sets, weight, iterations);

            //WorkoutExerciseController controller2 = new WorkoutExerciseController(name, category);

            //Assert.AreEqual(name, controller2.CurrentExercise.Name);
            //Assert.AreEqual(category, controller2.CurrentExercise.Category);
            //Assert.AreEqual(description, controller2.CurrentExercise.Description);
            //Assert.AreEqual(sets, controller2.CurrentExercise.Sets);
            //Assert.AreEqual(weight, controller2.CurrentExercise.Weight);
            //for (var i = 0; i < sets; i++)
            //{
            //    Assert.AreEqual(iterations[i], controller2.CurrentExercise.Iterations[i]);
            //}

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