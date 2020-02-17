using NUnit.Framework;
using System;
using LabTaskConsole;

namespace LabTaskTest
{
    [TestFixture]
    public class TestClass
    {
        static double myExpectedResult;
        static Program p1;

        [SetUp] // code here is executed before tests are executed
        public static void Init()
        {
            p1 = new Program();
        }

        [Test]
        public static void Test1()
        {
            myExpectedResult = 3; // what my code should be returning
            double actualResult = LabTaskConsole.Program.Divide(15, 5);
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        // paramaterised test – allows us group a bunch of tests
        [TestCase(9, 3, ExpectedResult = 3)]
        [TestCase(27, 3, ExpectedResult = 9)]
        [TestCase(120, 3, ExpectedResult = 40)]

        [Test]
        public double Test2(double a, double b)
        {
            myExpectedResult = -50; // what my code should be returning
            double actualResult = LabTaskConsole.Program.WithdrawFunds(50, 100);
            Assert.AreEqual(myExpectedResult, actualResult);

            return actualResult;
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestMethod1()
        {

            double myExpectedResult, actualResult;

            myExpectedResult = 2;               // Arrange ( set up test)
            actualResult = LabTaskConsole.Program.WithdrawFunds(5, 3);       // Act  ( do something)
            Assert.AreEqual(myExpectedResult, actualResult); // Assert (check) 
        }
    }
}
