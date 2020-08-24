using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double number,root;
            Console.WriteLine("Enter number:");
            number=Convert.ToDouble(Console.ReadLine());
            root=Math.Sqrt(number);
            Console.WriteLine($"Root of {number} is {root}");
        }
    }
}
//"console": "internalConsole",  OR "console": "integratedTerminal",