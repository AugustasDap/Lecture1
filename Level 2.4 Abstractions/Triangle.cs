using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._4_Abstractions
{
    internal class Triangle : GeometricShape
    {
        public Triangle(int borderA, int borderB, int borderC)
        {
            BorderA = borderA;
            BorderB = borderB;
            BorderC = borderC;
        }
        public int BorderA { get; set; }
        public int BorderB { get; set; }
        public int BorderC { get; set; }

        public override int GetPerimeter()
        {
            int perimeter = BorderA + BorderB + BorderC;
            return perimeter;
        }

        public override int GetArea()
        {
            int area = BorderA * BorderB / 2;
            return area;
        }
    }
}
