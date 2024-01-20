using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            int sumi = num1 + num2;

            float f1 = 3.35f;
            float f2 = 6.4f;
            float sumf = f1 + f2;

            double d1 = 3.225;
            double d2 = 3.3;
            double sumd = d1 + d2;

            Console.WriteLine($"El resultado de sumar {num1} más {num2} es: {sumi}");
            Console.WriteLine($"El resultado de sumar {f1} más {f2} es: {sumf}");
            Console.WriteLine($"El resultado de sumar {d1} más {d2} es: {sumd}");
            Console.ReadLine();
        }
    }
}
