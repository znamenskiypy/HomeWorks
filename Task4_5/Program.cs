// Запрос числа из диапазона
namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 вариант
            int n = 0;
            do
            {
                Console.WriteLine("Введите  число от 20 до 60");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <20 || n > 60);
            Console.WriteLine("Правильно");
            
            // 2 вариант
            int m = 0;                                       
            Console.WriteLine("Введите  число от 20 до 60");
            while (1 > 0)
            {
                m = Convert.ToInt32(Console.ReadLine());
                if (m >= 20 && m <= 60)
                {
                    Console.WriteLine("Правильно");
                    break;
                }
                else
                {
                    continue;
                }
            }
                
            Console.ReadKey();

        }
    }
}