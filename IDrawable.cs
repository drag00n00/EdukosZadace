using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukosS.O.L.I.D_
{
    internal interface IDrawable
    {
        public void Draw(Object type);
    }

    class GraphicEditor
    {

    }

    class Rectangle : IDrawable
    {
        //...

        public void Draw() { //implementation }
    }

    class Triangle : IDrawable
    {
        //...

        public void Draw() { //implementation }
    }

    class Circle : IDrawable
    {
        //...

        public void Draw() { //implementation }
    }
    class GraphicEditor
    {
        public void DrawShape(IDrawable shape)
        {
            shape.Draw();
        }
                }
}
