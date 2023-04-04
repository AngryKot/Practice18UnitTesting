using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics.Metrics;
using UnitTest18Pract;

namespace TestingProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstPositiveCase()
        {
            // Arrange
            double a = -2.0;
            double b = 3.0;
            double c = 1.0;
            double x = 2.0;
            double expected = (a*(x*x))+((b*b)*x);

            var counter = new ClassCount();

            // Act
            counter.Count(x, a, b, c);
            double actual = counter.GetResult();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestSecondPositiveCase()
        {
            // Arrange
            double a = 3.0;
            double b = 1.0;
            double c = 2.0;
            double x = 0.0;
            double expected = x - (a / (x - c));

            var counter = new ClassCount();

            // Act
            counter.Count(x, a, b, c);
            double actual = counter.GetResult();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThirdPositiveCase()
        {
            // Arrange
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;
            double x = 4.0;
            double expected = 1 + (x / c);

            var counter = new ClassCount();

            // Act
            counter.Count(x, a, b, c);
            double actual = counter.GetResult();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestFirstNegativeCase()
        {
            // Arrange
            double a = 2.0;
            double b = 3.0;
            double c = 1.0;
            double x = -1.0;
            double expected = (a * (x * x)) + ((b * b) * x);

            var counter = new ClassCount();

            // Act
            counter.Count(x, a, b, c);
            double actual = counter.GetResult();

            // Assert
            Assert.AreNotEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestSecondNegativeCase()
        {
            // Arrange
            double a = 0.0;
            double b = 1.0;
            double c = 2.0;
            double x = 1.0;
            double expected = x - (a / (x - c));

            var counter = new ClassCount();

            // Act
            counter.Count(x, a, b, c);
            double actual = counter.GetResult();

            // Assert
            Assert.AreNotEqual(expected, actual);
        }

    }
}