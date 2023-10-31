using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYMLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller.Tests
{
    [TestClass()]
    public class ExerciseControllerTests
    {
        [TestMethod()]
        public void SetNewExerciseDataTest()
        {
            var name = Guid.NewGuid().ToString();
            var category = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();

            ExerciseController exerciseController = new ExerciseController(name, category);

            exerciseController.SetNewExerciseData(description);

            ExerciseController exerciseController2 = new ExerciseController(name, category);

            Assert.AreEqual(name, exerciseController2.CurrentExercise.Name);
            Assert.AreEqual(category, exerciseController2.CurrentExercise.Category);
            Assert.AreEqual(description, exerciseController2.CurrentExercise.Description);
        }

        [TestMethod()]
        public void SaveTest()
        {
            var name = Guid.NewGuid().ToString();
            var category = Guid.NewGuid().ToString();


            var controller = new ExerciseController(name, category);

            Assert.AreEqual(name, controller.CurrentExercise.Name);
            Assert.AreEqual(category, controller.CurrentExercise.Category);
        }
    }
}