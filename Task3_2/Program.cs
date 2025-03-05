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
            //switch (a)
            //{
                //case  >b && > c:    //тут возникает ошибка, не знаю как синтаксически правильно записать такое условие в case
                    //Console.WriteLine('a');
                    //break;
                //case  >b && <c:
                    //Console.WriteLine('c');
                    //break;
                //default:
                    //Console.WriteLine('b');
                    //break;

            //}

            if (a > b && a > c)
            {
                Console.WriteLine('a');
            }
            else if (a > b && b < c || a < b && b < c)
            {
                Console.WriteLine('c');
            }
            else if (a < b && b > c)
            {
                Console.WriteLine('b');
            }

            Console.ReadKey();
        }
    }
}
