//Поменять местами значения переменных
namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;



            Console.WriteLine("a = {0},b = {1}",a,b);
            Console.ReadKey();
        }
    }
}
