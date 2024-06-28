using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_with_No_Argument_and_No_Return_Type
{
     class Program
    {
        static void Main(string[] args)
        {
            Sum(); //method has no arguments
            Console.ReadLine();
        }
        // void is the return type of a function  
        static void Sum()
        {
            int x = 30;
            int y = 20;
            int sum = x + y;
            Console.WriteLine($"Sum of {x} and {y} is {sum}");
        }
    }
}
