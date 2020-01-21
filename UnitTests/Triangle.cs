using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest;
using System;

namespace UnitTests
{   
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetAreaTest_a4_b3_c5()
        {
            var a = 4;
            var b = 3;
            var c = 5;
                                 
            var triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void GetAreaTest_a6_b6_c3()
        {
            var a = 6;
            var b = 6;
            var c = 3;

            var triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();

            Assert.AreEqual(8.714, area);
        }

        [TestMethod]
        public void GetPerimeterTest_a4_b3_c5()
        {
            var a = 4;
            var b = 3;
            var c = 5;

            var triangle = new Triangle(a, b, c);

            var area = triangle.GetPerimeter();

            Assert.AreEqual(12, area);
        }

        [TestMethod]
        public void GetPerimeterTest_a6_b6_c3()
        {
            var a = 6;
            var b = 6;
            var c = 3;

            var triangle = new Triangle(a, b, c);

            var area = triangle.GetPerimeter();

            Assert.AreEqual(15, area);
        }

        public void IsRectangularTest()
        {
            var a = 4;
            var b = 3;
            var c = 5;

            var triangle = new Triangle(a, b, c);

            var isRectangular = triangle.IsRectangular();

            Assert.IsTrue(isRectangular);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Длинна сторон треугольника не может быть меньше 0")]
        public void TriangleTest_arg0()
        {
            var a = -1;
            var b = 3;
            var c = 5;

            var triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Фигура с заданными сторонами не является треугольником")]
        public void TriangleTest_notTriangle()
        {
            var a = 9;
            var b = 3;
            var c = 5;

            var triangle = new Triangle(a, b, c);
        }
    }
}
