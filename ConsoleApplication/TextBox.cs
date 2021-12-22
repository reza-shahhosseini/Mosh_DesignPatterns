using System;
namespace ConsoleApplication{
    public class TextBox:UIControl{
        public TextBox(string name):base(name){}

        public override void Draw()
        {
            Console.WriteLine("Drawing a Text Box ...");
        }
    }
}