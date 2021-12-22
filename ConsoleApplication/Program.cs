using System;
using ConsoleApplication.Interfaces;
using ConsoleApplication.Memento;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [Interfaces]
            /*
            ITaxCalculator taxCalculator = GetTaxCalculator();
            taxCalculator.CalculateTax();
            */
            #endregion

            #region [Encapsulation]
            /*
            var account = new Account();
            Console.WriteLine(account.Balance);
            account.Deposit(100);
            account.Withdraw(30);
            Console.WriteLine(account.Balance);
            */
            #endregion

            #region [Abstraction]
            /*
            var mailService = new MailService();
            mailService.SendEmail("Hello There");
            */
            #endregion

            #region [Inheritance]
            /*
            var txt1 = new TextBox("txt1");
            txt1.Focus();
            */
            #endregion

            #region [Polymorphism]
            /*
            Print(new CheckBox("checkbox1"));
            */
            #endregion

            #region [Memento]
            /* ***** Problem ***** */
            /*
            var editor = new Editor();
            editor.Content="A";
            editor.Content="B";
            editor.Content="C";
            editor.Undo();
            Console.WriteLine(editor.Content);
            */

            /* ***** Solution ***** */
            var editor = new Editor();
            var history = new History();

            editor.Content="A";
            history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "B";
            history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "C";
            Console.WriteLine(editor.Content);

            editor.RestoreState(history.Pop());
            Console.WriteLine(editor.Content);

            editor.RestoreState(history.Pop());
            Console.WriteLine(editor.Content);

            #endregion
        }

        private static ITaxCalculator GetTaxCalculator(){
            return new TaxCalculator2021();
        }

        private static void Print(UIControl control){
            control.Draw();
        }
    }
}
