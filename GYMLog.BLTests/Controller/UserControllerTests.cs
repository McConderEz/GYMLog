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
    public class UserControllerTests
    {

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            var userName = Guid.NewGuid().ToString();
            var password = Guid.NewGuid().ToString();
            var birthdate = DateTime.Now.AddYears(-18);
            var gender = "man";
            var weight = 90;
            var height = 190;
            
            var controller = new UserController(userName, password);


            controller.SetNewUserData(gender,birthdate,weight,height);

            var controller2 = new UserController(userName, password);

            Assert.AreEqual(userName, controller2.CurrentUser.Login);
            Assert.AreEqual(password, controller2.CurrentUser.Password);
            Assert.AreEqual(birthdate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
        }

        [TestMethod()]
        public void SaveTest()
        {
            
            var userName = Guid.NewGuid().ToString();
            var password = Guid.NewGuid().ToString();   


            var controller = new UserController(userName,password);

            Assert.AreEqual(userName, controller.CurrentUser.Login);
            Assert.AreEqual(password,controller.CurrentUser.Password);
        }
    }
}