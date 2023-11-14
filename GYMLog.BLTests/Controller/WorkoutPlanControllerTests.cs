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
        //TODO:Протестировать изменения
        [TestMethod()]
        public void SetNewWorkoutPlanDataTest()
        {
            var planName = Guid.NewGuid().ToString();
            var day = Guid.NewGuid().ToString();
            var notes = Guid.NewGuid().ToString();

            var userName = Guid.NewGuid().ToString();
            var password = Guid.NewGuid().ToString();
            var birthdate = DateTime.Now.AddYears(-18);
            var gender = "man";
            var weight = 90;
            var height = 190;

            var controllerUser = new UserController(userName, password);


            controllerUser.SetNewUserData(gender, birthdate, weight, height);

            var controller = new WorkoutPlanController(controllerUser.CurrentUser);

            var controllerExercises = new WorkoutExerciseController("asdas", "asdas");

            controllerExercises.SetNewExerciseData("test", 3,new (double,int)[]{(1,5), (4,1), (2,4) });


            controller.Add(controllerExercises.CurrentExercise, controllerExercises.CurrentExercise.Sets, controllerExercises.CurrentExercise.SetsParams.ToArray());

            var controller2 = new WorkoutPlanController(controllerUser.CurrentUser);


            for (var i = 0; i < controller2.WorkoutPlan.ExerciseList.Count; i++)
            {
                Assert.AreEqual(controllerExercises.Exercises[i].Name, controller2.WorkoutPlan.ExerciseList[i].Name);
                Assert.AreEqual(controllerExercises.Exercises[i].Category, controller2.WorkoutPlan.ExerciseList[i].Category);
                Assert.AreEqual(controllerExercises.Exercises[i].Description, controller2.WorkoutPlan.ExerciseList[i].Description);
                Assert.AreEqual(controllerExercises.Exercises[i].Sets, controller2.WorkoutPlan.ExerciseList[i].Sets);
                Assert.AreEqual(controllerExercises.Exercises[i].SetsParams[i].Item1, controller2.WorkoutPlan.ExerciseList[i].SetsParams[i].Item1);               
            }


        }

        [TestMethod()]
        public void SaveTest()
        {
            //var planName = Guid.NewGuid().ToString();

            //var controller = new WorkoutPlanController(planName);

            //Assert.AreEqual(planName,controller.currentWorkoutPlan.PlanName);
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