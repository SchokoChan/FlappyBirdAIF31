using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlappyBird
{



    [TestClass]
    public class ViewGameTests
    {
        [TestMethod]
        public static void TestPlayerDeath()
        {
            ControllerGame.spielerLebt = true;
            ControllerGame.score = 5;
            ControllerGame.userData = new User("Admin", "XxsXVJmqArfCEO7sXKPtDptZ0xo02fUkw5rCeqhYcN4=", "cys2v1yP", 5, 20);
            ViewGame.playerDeath();
            Assert.IsFalse(ControllerGame.spielerLebt);
            Assert.AreEqual(5, ControllerGame.userData.Highscore);
        }
    }

    [TestClass]
    public  class ControllerGameTests
    {

        

        [TestMethod]
        public static void TestChangeScore()
        {
            ControllerGame.userData = new User("TestUser", "HashedPassword", "Salt", 10, 0);
            ControllerGame.score = 10;
            ControllerGame.changeScore();
            Assert.AreEqual(10, ControllerGame.userData.Highscore);
        }
    }

    [TestClass]
    public class ControllerAnmeldeFormularTests
    {
        [TestMethod]
        public static void TestUserRegistrierung()
        {
            ControllerAnmeldeFormular controller = new ControllerAnmeldeFormular();
            bool result = controller.userRegistrierung("TestUser", "TestPassword");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public static void TestUserAnmeldung()
        {
            ControllerAnmeldeFormular controller = new ControllerAnmeldeFormular();
            bool result = controller.userAnmeldung("TestUser", "TestPassword");
            Assert.IsTrue(result);
        }
    }
    [TestClass]
    public class ModelAnmeldeFormularTests
    {
        [TestMethod]
        public static void TestBenutzerExistiert()
        {
            ModelAnmeldeFormular model = new ModelAnmeldeFormular();
            bool result = model.benutzerExsistiert("TestUser");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public static void TestUserInDatenbankEinfuegen()
        {
            ModelAnmeldeFormular model = new ModelAnmeldeFormular();
            bool result = model.userInDatenbankEinfuegen("TestUser", "TestPassword", "AAAAAAAA");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public static void TestUserAusDatenbankLesen()
        {
            ModelAnmeldeFormular model = new ModelAnmeldeFormular();
            User user = model.userAusDatenbankLesen("Admin");
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public static void TestGeneriereSalt()
        {
            ModelAnmeldeFormular model = new ModelAnmeldeFormular();
            string salt = model.generiereSalt();
            Assert.AreEqual(8, salt.Length);
        }

        [TestMethod]
        public static void TestHashPasswort()
        {
            ModelAnmeldeFormular model = new ModelAnmeldeFormular();
            string hashedPassword = model.hashPasswort("Passwort", "AAAAAAAA");
            Assert.IsNotNull(hashedPassword);
        }
    }
}
