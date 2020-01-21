using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest;
using System;

namespace UnitTests
{   
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaTest_rad5()
        {
            var radius = 5;
            var expectedArea = 78.54;
            var circle = new Circle(radius);

            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetAreaTest_rad120()
        {
            var radius = 120;
            var expectedArea = 45238.934;
            var circle = new Circle(radius);

            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetPerimeterTest_rad5()
        {
            var radius = 5;
            var expectedArea = 31.416;
            var circle = new Circle(radius);

            var actualArea = circle.GetPerimeter();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetPerimeterTest_rad120()
        {
            var radius = 120;
            var expectedArea = 753.982;
            var circle = new Circle(radius);

            var actualArea = circle.GetPerimeter();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Радиус окружности не может быть меньше 0")]
        public void CircleTest_rad0()
        {
            var radius = -12;

            var circle = new Circle(radius);
        }
    }
}
