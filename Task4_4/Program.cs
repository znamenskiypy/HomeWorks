//Возведение в отрицательную степень
namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень (отрицательную)");
            int b = Convert.ToInt32(Console.ReadLine());

            int baseNum = 1;
            int posB = b*(-1);

            for (int i = 1; i <= posB; i++)   //находим знаменатель дроби (число в положительной степени)
            {
                baseNum *= a;
            }

            decimal res = 1 / Convert.ToDecimal(baseNum);   //находим итоговое значение

            Console.WriteLine("{0} в степени {1} будет {2}", a, b, res);
            Console.ReadKey();

        }
    }
}