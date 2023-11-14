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
    public class EatingControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var userName = Guid.NewGuid().ToString();
            var password = Guid.NewGuid().ToString();
;

            var foodName = Guid.NewGuid().ToString();
            Random rnd = new Random();

            var userController = new UserController(userName,password);
            var eatingContoller = new EatingController(userController.CurrentUser);

            var food = new Food(foodName,rnd.Next(50,500), rnd.Next(50, 500), rnd.Next(50, 500), rnd.Next(50, 500));


            eatingContoller.Add(food, 100);


            Assert.AreEqual(food.Name, eatingContoller.Eating.Foods.First().Food.Name);

        }
    }
}