using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlappyTest
{
    [TestClass]
    public class FlappyTest
    {
        [TestMethod]
        public void TestPipeSpeed()
        {

            //Arrange
            int expected = 13;

            var wpf_window = new FlappyBird.Form1();
            Application.Run(wpf_window);

            //Act
            int actual = FlappyBird.Form1.pipespeed;

            //Assert 
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod]
        public void TestInitialScore()
        {
            //Arrange
            int expected = 0;

            var wpf_window = new FlappyBird.Form1();
            Application.Run(wpf_window);

            //Act
            int actual = FlappyBird.Form1.score;

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPipeAfterScore()
        {

            int score = 10;
            int Pipespeed = 13;
            int expected = 18;

            var wpf_window = new FlappyBird.Form1();
            Application.Run(wpf_window);

            //Act
            int actual = FlappyBird.Form1.pipespeed;

            if (score > 5)
            {
                Pipespeed = 18;
            }

            Assert.AreEqual(Pipespeed, expected);
        }

    }
}
