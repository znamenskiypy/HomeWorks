
//больше, меньше или равно

namespace Task3_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
            Console.ReadKey();
        }
    }
}