// Кол-во знаков в числе
namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  число");
            double n = Convert.ToDouble(Console.ReadLine());
            //ищем модуль числа
            double m = 0;
            if (n >= 0)
            {
                m = n;
            }
            else
            {
                m = -n;
            }
            int i = 1; //заводим счетчик
            while (true)
            {
                m /= 10;
                if (m < 1)
                {
                    Console.WriteLine("Число {0} содержит {1} знак(ов)",n, i);
                    break;   
                }
                else 
                {
                    i++;
                }
                
            }
            Console.ReadKey();

        }
    }
}
