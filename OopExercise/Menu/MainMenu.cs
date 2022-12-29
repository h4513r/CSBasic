using OopExercise.Dal;
using OopExercise.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopExercise.ExtentionMethod;

namespace OopExercise.Menu;
internal class MainMenu
{

    public static void Show()
    {
        DalProduct dal = new();
        while (true)
        {
            dal.ChangeColor(ConsoleColor.White, ConsoleColor.Green);
            Console.WriteLine("please choose: ");
            Console.WriteLine("1 - add product: ");
            Console.WriteLine("2 - show list: ");
            Console.WriteLine("not in (1,2) - exit: ");
            var n =  Validate<int>.Input("please enter number");
            switch (n)
            {
                case 1 :
                    dal.ChangeColor(ConsoleColor.White, ConsoleColor.Blue);
                    dal.Add();
                    break;
                case 2 :
                    dal.ChangeColor(ConsoleColor.White, ConsoleColor.Red);
                    dal.Show();
                    break;
                default:
                    Console.WriteLine("exit");
                    return;
            }
        }
    }
}
