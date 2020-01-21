using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTest
{
    public class Triangle : Figure, ITriangle
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Длинна сторон треугольника не может быть меньше 0");

            if (!(a + b > c && b + c > a && a + c > b))
                throw new Exception("Фигура с заданными сторонами не является треугольником");

            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Рассчитать площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        protected override double CalcArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            _area = Math.Sqrt(halfPerimeter * (halfPerimeter - _a) * (halfPerimeter - _c) * (halfPerimeter - _b));
            return _area;
        }

        /// <summary>
        /// Рассчитать периметр треугольника
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        protected override double CalcPerimeter()
        {
            _perimeter = _a + _b + _c;
            return _perimeter;
        }

        /// <summary>
        /// Теорема пифагора
        /// </summary>
        /// <param name="cathet1"></param>
        /// <param name="cathet2"></param>
        /// <param name="hypotenuse"></param>
        /// <returns></returns>
        public bool PythagoreanTheorem(double cathet1, double cathet2, double hypotenuse)
        {
            return Math.Pow(cathet1, 2) + Math.Pow(cathet2, 2) == Math.Pow(hypotenuse, 2);
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            if (PythagoreanTheorem(_a, _b, _c) || PythagoreanTheorem(_c, _b, _a) || PythagoreanTheorem(_a, _c, _b))
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
