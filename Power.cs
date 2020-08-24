using System;
 class Program
    {
        public static double GetPower()
        {
            int x,y;
            double power;
            Console.WriteLine("Enter first number:");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            y=Convert.ToInt32(Console.ReadLine());
            power=Math.Pow(x,y);
            Console.WriteLine($"{x}  power {y} = {power}");
            return power;
        }
    }
