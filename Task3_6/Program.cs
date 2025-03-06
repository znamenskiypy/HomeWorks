//Четное или нечетное
namespace Task3_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Четное или нет? Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
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
