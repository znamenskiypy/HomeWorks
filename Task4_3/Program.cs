// Возведение в положительную степень
namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int b = Convert.ToInt32(Console.ReadLine());

            int res = 1;

            for (int i = 1; i <= b; i++)
            {
                res *= a;
            }

            Console.WriteLine("{0} в степени {1} будет {2}", a, b, res);
            Console.ReadKey();

        }
    }
}



