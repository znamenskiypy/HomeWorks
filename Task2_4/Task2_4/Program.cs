//Поменять местами 2 и 4 цифру
namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(num / 1000);
            int b = Convert.ToInt32((num - a * 1000) / 100);
            int c = Convert.ToInt32((num - a * 1000 - b * 100) / 10);
            int d = Convert.ToInt32(num - a * 1000 - b * 100 - c * 10);

            int e = b;
            b = d;
            d = e;

            int res = a * 1000 + b * 100 + c * 10 + d;


            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}