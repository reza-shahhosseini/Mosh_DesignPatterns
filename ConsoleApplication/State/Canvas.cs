using System;
namespace ConsoleApplication.State{
    public class Canvas{
        //public ToolType CurrentTool{get;set;}
        public ITool CurrentTool{get;set;}// Programming to interface

        /*
        public void MouseDown_OLD_VERSION(){
            // if(CurrentTool == ToolType.Selection) Console.WriteLine("Selection cursor");
            // else if(CurrentTool == ToolType.Brush) Console.WriteLine("Brush cursor");
            // else if(CurrentTool == ToolType.Eraser) Console.WriteLine("Eraser cursor");

            // using switch statement instead of if-else
            switch(CurrentTool){
                case ToolType.Selection:
                    Console.WriteLine("Selection cursor");
                    break;
                case ToolType.Brush:
                    Console.WriteLine("Brush cursor");
                    break;
                case ToolType.Eraser:
                    Console.WriteLine("Eraser cursor");
                    break;
                default: 
                    break;
            }
        }
        */

        /*
        public void MouseUp_OLD_VERSION(){
            switch(CurrentTool){
                case ToolType.Selection:
                    Console.WriteLine("Draw a rectangle on canvas");
                    break;
                case ToolType.Brush:
                    Console.WriteLine("Draw a line on the canvas");
                    break;
                case ToolType.Eraser:
                    Console.WriteLine("Erase something on the canvas");
                    break;
                default:
                    break;
            }
        }
        */

        public void MouseDown() => CurrentTool.MouseDown();
        public void MouseUp()=>CurrentTool.MouseUp();

    }
}