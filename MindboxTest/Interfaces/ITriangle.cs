using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTest
{
    interface ITriangle
    {
        bool PythagoreanTheorem(double cathet1, double cathet2, double hypotenuse);

        bool IsRectangular();
    }
}
