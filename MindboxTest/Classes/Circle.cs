using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTest
{    
    public class Circle : Figure
    {
        private readonly double _radius;
        
        public Circle(double r)
        {
            if (r < 0)
                throw new Exception("Радиус окружности не может быть меньше 0");

            _radius = r;
        }

        /// <summary>
        /// Рассчитать площадь окружности
        /// </summary>
        /// <returns>Площадь окружности</returns>
        protected override double CalcArea()
        {
            _area = Math.PI * Math.Pow(_radius, 2);
            return _area;
        }

        /// <summary>
        /// Рассчитать периметр окружности
        /// </summary>
        /// <returns>Периметр окружности</returns>
        protected override double CalcPerimeter()
        {
            _perimeter = 2 * Math.PI * _radius;
            return _perimeter;
        }
    }    
}
