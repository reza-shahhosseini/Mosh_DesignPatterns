using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication.State
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser Cursor");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something on the canvas.");
        }
    }
}