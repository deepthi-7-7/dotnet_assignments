using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid__Principles
{
    internal class LSP
    {
        public abstract class Shape
        {
            public abstract int Area();
        }

        public class Rectangle : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public override int Area()
            {
                return Width * Height;
            }
        }

        public class Square : Shape
        {
            public int SideLength { get; set; }

            public override int Area()
            {
                return SideLength * SideLength;
            }
        }
    }
}
