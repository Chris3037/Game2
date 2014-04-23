using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game2
{
    class Program
    {
        //Public variables
        static string userName = "";
        static string input = "";

        static void Main(string[] args)
        {
            Welcome();
        }

        //Welcome Function
        static void Welcome()
        {
            Console.WriteLine("Please enter your name");
            input = Console.ReadLine();
            userName = input;
            Console.Clear();
            Console.WriteLine("Welcome to the game " + userName);

            End();
        }

        //End Function
        static void End()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }
}
