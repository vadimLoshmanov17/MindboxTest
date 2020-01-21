using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTest
{
    public abstract class Figure : IFigure
    {
        protected double _area;
        protected double _perimeter;

        protected virtual double CalcArea()
        {
            return _area;
        }

        protected virtual double CalcPerimeter()
        {
            return _perimeter;
        }

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.Round(CalcArea(), 3);
        }

        /// <summary>
        /// Получить периметр фигуры
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return Math.Round(CalcPerimeter(), 3);
        }
    }
}
