namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine(a + b);
                }
                else if (c == 2)
                {
                    Console.WriteLine(a - b);
                }
                else if (c == 3)
                {
                    Console.WriteLine(a * b);
                }
                else if (c == 4)
                {
                    Console.WriteLine(a / b);
                }
                else 
                {
                    Console.WriteLine("Некорректный код операции");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            Console.ReadKey();
        }
    }
}
