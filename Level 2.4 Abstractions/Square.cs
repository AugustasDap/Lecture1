using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._4_Abstractions
{
    internal class Square : GeometricShape
    {
        public Square(int height, int width)
        {
            Height = height;
            Width = width;
        }
        public int Height { get; set; }
        public int Width { get; set; }

        public override int GetPerimeter()
        {
            int perimeter = (Height * 2) + (Width * 2);
            return perimeter;
        }

        public override int GetArea()
        {
            int area = Height * Width;
            return area;
        }
    }
}
