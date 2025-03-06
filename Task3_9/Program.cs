//Попадает ли в диапазон1 ИЛИ в диапазон2
namespace Task3_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= -10 || a >= 10)
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
