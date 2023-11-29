using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4;

namespace Task_4
{
    public class GraphicsEditor
    {
        private List<GraphicPrimitive> graphics = new List<GraphicPrimitive>();

        public void AddGraphicPrimitive(GraphicPrimitive primitive)
        {
            graphics.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in graphics)
            {
                primitive.Draw();
            }
        }
    }

}