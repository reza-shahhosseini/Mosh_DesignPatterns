using System;
namespace ConsoleApplication{
    public class CheckBox:UIControl{
        public CheckBox(string name):base(name){}

        public override void Draw()
        {
            Console.WriteLine("Draw a CheckBox ...");
        }
    }
}