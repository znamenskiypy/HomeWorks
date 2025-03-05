// Построили дом/а/ов
namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество домов:");
            int n = Convert.ToInt32(Console.ReadLine());
            string word = "дом";
            if (n>10 && n<21)
            {
                word = "домов";
            }
            else if (n % 10 == 1)
            {
                word = "дом";
            }
            else if (n % 10 >1 && n%10 <5)
            {
                word = "дома";
            }
            else
            {
                word = "домов";
            }
            Console.WriteLine("Мы построили {0} {1}", n, word);
            Console.ReadKey();
        }
    }
}
