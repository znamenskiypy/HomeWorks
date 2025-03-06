//Двузначное или нет
namespace Task3_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Двузначное или нет? Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 && a < 100)
            {
                Console.WriteLine("Да");
            }
            else if (a < -9 && a > -100)
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
