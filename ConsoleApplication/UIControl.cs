using System;
namespace ConsoleApplication{
    public abstract class UIControl{

        public UIControl(string name){
            Name = name;
        }

        public string Name { get; init; }


        public void Focus(){
            Console.WriteLine($"{Name} has been focused.");
        }

        public abstract void Draw();
    }
}