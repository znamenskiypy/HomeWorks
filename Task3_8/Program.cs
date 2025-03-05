//Попадает ли в диапазон
namespace Task3_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=-10 && a<=10)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");

            }
            Console.ReadKey();
        }
    }
}