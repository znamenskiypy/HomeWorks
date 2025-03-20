//Факториал
namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            int m = 1;
            for (int i = 1; i <= n; i++)
            {
                m *= i;
            }
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
