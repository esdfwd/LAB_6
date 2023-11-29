using System.Drawing;
using System.Text.RegularExpressions;
using Task_4;

namespace Task_4
{
    class Program
    {
        static void Main()
        {

            Circle circle = new Circle { X = 10, Y = 20, Radius = 5 };
            Rectangle rectangle = new Rectangle { X = 30, Y = 40, Width = 8, Height = 12 };
            Triangle triangle = new Triangle { X = 50, Y = 60 };

            Group group = new Group { X = 0, Y = 0 };
            group.AddPrimitive(circle);
            group.AddPrimitive(rectangle);
            group.AddPrimitive(triangle);

            GraphicsEditor editor = new GraphicsEditor();
            editor.AddGraphicPrimitive(circle);
            editor.AddGraphicPrimitive(rectangle);
            editor.AddGraphicPrimitive(triangle);
            editor.AddGraphicPrimitive(group);

            // Виведення до
            editor.DrawAll();

            circle.Scale(2.0f);
            rectangle.Scale(1.5f);

            group.Move(5, 5);

            // Виведення після 
            editor.DrawAll();
        }
    }
}