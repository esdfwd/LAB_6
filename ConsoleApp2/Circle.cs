using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4;

namespace Task_4
{
    public class Circle : GraphicPrimitive
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle at ({X}, {Y}) with radius {Radius}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Radius = (int)(Radius * factor);
        }
    }
}
