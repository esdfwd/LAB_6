using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4;

namespace Task_4
{
    public class Triangle : GraphicPrimitive
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle at ({X}, {Y})");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            // Реалізація масштабування для трикутника (просто для прикладу)
        }
    }
}