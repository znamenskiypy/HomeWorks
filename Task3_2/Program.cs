//Большее из трех
namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case (> b) when a > c:
                    Console.WriteLine('a');
                    break;
                case (>b) when  a <c:
                    Console.WriteLine('c');
                    break;
                case (< b) when a < c:
                    Console.WriteLine('b');
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
