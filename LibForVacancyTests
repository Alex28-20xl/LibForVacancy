using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibForVacancy;

namespace LibTests
{
    [TestClass]
    public class LibForVacancyTests
    {
        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-3));
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            //arrange
            Circle circle = new Circle(10);

            //act
            var circleArea = circle.Area;

            //assert
            Assert.AreEqual(314.15926535897931, circleArea);
        }

        [TestMethod]
        public void TriangleNegativeSidesTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, 0, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, -10, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 10, -1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, -10, -1));
        }

        [TestMethod]
        public void TriangleCalculateAreaTest()
        {
            //arrage
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            var calcArea = triangle.Area;

            //assert
            Assert.AreEqual(6, calcArea);
        }

        [TestMethod]
        public void TriangleRightTest()
        {
            //arrage
            Triangle triangle = new Triangle(15, 20, 25);

            //act
            var isTriangleRight = triangle.IsTriangleRight;

            //assert
            Assert.AreEqual(true, isTriangleRight);
        }

        [TestMethod]
        public void TriangleNotRightTest()
        {
            //arrage
            Triangle triangle = new Triangle(20, 20, 25);

            //act
            var isTriangleRight = triangle.IsTriangleRight;

            //assert
            Assert.AreEqual(false, isTriangleRight);
        }
    }
}
