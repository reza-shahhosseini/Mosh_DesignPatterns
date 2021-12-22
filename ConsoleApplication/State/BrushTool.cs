using System;
namespace ConsoleApplication.State{
    public class BrushTool : ITool{

        public void MouseDown(){
            Console.WriteLine("Brush Icon");
        }

        public void MouseUp(){
            Console.WriteLine("Draw a line on the canvas");
        }
    }
}