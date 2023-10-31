using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYMLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GYMLog.BL.Controller.Tests
{
    [TestClass()]
    public class WorkoutPlanControllerTests
    {
        [TestMethod()]
        public void SetNewWorkoutPlanDataTest()
        {
            var planName = Guid.NewGuid().ToString();
            var day =  Guid.NewGuid().ToString();
            var notes = Guid.NewGuid().ToString();

            var controller = new WorkoutPlanController(planName);

            var controllerExercises = new WorkoutExerciseController("asdas","asdas");

            controller.SetNewWorkoutPlanData(controllerExercises.Exercises, day, notes);

            var controller2 = new WorkoutPlanController(planName);

            Assert.AreEqual(planName, controller2.currentWorkoutPlan.PlanName);
            Assert.AreEqual(day, controller2.currentWorkoutPlan.Day);
            Assert.AreEqual(notes, controller2.currentWorkoutPlan.Notes);

            for(var i = 0;i < controller2.currentWorkoutPlan.ExerciseList.Count;i++)
            {
                Assert.AreEqual(controllerExercises.Exercises[i].Name, controller2.currentWorkoutPlan.ExerciseList[i].Name);
                Assert.AreEqual(controllerExercises.Exercises[i].Category, controller2.currentWorkoutPlan.ExerciseList[i].Category);
                Assert.AreEqual(controllerExercises.Exercises[i].Description, controller2.currentWorkoutPlan.ExerciseList[i].Description);
                Assert.AreEqual(controllerExercises.Exercises[i].Sets, controller2.currentWorkoutPlan.ExerciseList[i].Sets);
                Assert.AreEqual(controllerExercises.Exercises[i].Weight, controller2.currentWorkoutPlan.ExerciseList[i].Weight);
                for (var j = 0; i < controllerExercises.Exercises[i].Sets; i++)
                {
                    Assert.AreEqual(controllerExercises.Exercises[i].Iterations[j], controller2.currentWorkoutPlan.ExerciseList[i].Iterations[j]);
                }
            }


        }

        [TestMethod()]
        public void SaveTest()
        {
            var planName = Guid.NewGuid().ToString();

            var controller = new WorkoutPlanController(planName);

            Assert.AreEqual(planName,controller.currentWorkoutPlan.PlanName);
        }

        public void CreateTestExercises()
        {
            WorkoutExerciseController controller;
            for (var i = 0; i < 10; i++)
            {
                Random rand = new Random();
                var name = Guid.NewGuid().ToString();
                var category = Guid.NewGuid().ToString();
                var description = Guid.NewGuid().ToString();

                var sets = rand.Next(1, 10);
                var weight = rand.Next(0, 100);
                int[] iterations = new int[sets];

                for (var j = 0; j < sets; j++) { iterations[j] = rand.Next(1, 100); }

                controller = new WorkoutExerciseController(name, category);
            }           
        }
    }
}