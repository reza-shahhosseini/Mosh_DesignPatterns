using System;
namespace ConsoleApplication.State{
    public class SelectionTool : ITool{
        
        public void MouseDown(){
            Console.WriteLine("Selection Cursor");
        }

        public void MouseUp(){
            Console.WriteLine("Draw a rectanle on the canvas");
        }
    }
}