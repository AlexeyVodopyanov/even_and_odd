using System;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            WriteLine("Четное или нечетное число");
            Write("Введите число ");
            int a;
            a = Convert.ToInt32(ReadLine());
            if (a % 2 == 0)
            {
                WriteLine($"{a} это четное");
            }
            else
            {
                WriteLine($"{a} это нечетное");
            }
        }
    }
}
