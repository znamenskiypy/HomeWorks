﻿//Обменять местами
namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

           int d = a;
            a = c;
            c = b;
            b = d;

            Console.WriteLine("a={0}, b = {1}, c = {2}",a,b,c);
            Console.ReadKey();

        }
    }
}