using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int myExpectedResult, actualResult;

            myExpectedResult = 2;               // Arrange ( set up test)
            actualResult = HelloWorld.Program.Subtract(5, 3);       // Act  ( do something)
            Assert.AreEqual(myExpectedResult, actualResult); // Assert (check) 
        }
    }
}
