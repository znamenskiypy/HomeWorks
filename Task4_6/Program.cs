// Является ли степенью двойки?
namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a;
            int i = 1;
           
            while (true)
            {
                if(a == 1)
                {
                    Console.WriteLine("{0} является двойкой в нулевой степени", a);
                    break;
                }
                else if (b == 2)
                {
                    Console.WriteLine("{0} является двойкой в степени {1}", a, i);
                    break;
                }
                else if (b < 2)
                {
                    Console.WriteLine("{0} не является степенью двойки", a);
                    break;
                }
                else 
                {
                    b /= 2;
                    i++;
                }
            }
            Console.ReadKey();

        }
    }
}