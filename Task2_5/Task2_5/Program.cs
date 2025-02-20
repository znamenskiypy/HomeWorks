//Округлить в большую сторону
namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(Console.ReadLine());
            length = Math.Ceiling(length);


            Console.WriteLine(length);
            Console.ReadKey();
        }
    }
}