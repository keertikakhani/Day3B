using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B
{
    // Interface Example

    interface IDrawable
    {
        void Draw(); 
    }
    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
}
