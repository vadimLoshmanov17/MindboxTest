using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest;
using System;

namespace UnitTests
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void GetCircleAreaTest_rad5()
        {
            var radius = 5;
            var expectedArea = 78.54;
            Figure circle = new Circle(radius);

            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception), "Радиус окружности не может быть меньше 0")]
        public void CircleTest_rad0()
        {
            var radius = -3;

            Figure circle = new Circle(radius);
        }

        [TestMethod]
        public void GetTriangleAreaTest()
        {
            var a = 4;
            var b = 3;
            var c = 5;

            Figure triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();

            Assert.AreEqual(6, area);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Длинна сторон треугольника не может быть меньше 0")]
        public void TriangleTest_arg0()
        {
            var a = -1;
            var b = 3;
            var c = 5;

            Figure triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Фигура с заданными сторонами не является треугольником")]
        public void TriangleTest_notTriangle()
        {
            var a = 9;
            var b = 3;
            var c = 5;

            Figure triangle = new Triangle(a, b, c);
        }
    }   
}
