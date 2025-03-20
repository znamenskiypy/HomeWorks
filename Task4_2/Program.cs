//Найти сумму дробей
namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            decimal res = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal k = 1 / Convert.ToDecimal(i);
                res += k;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
