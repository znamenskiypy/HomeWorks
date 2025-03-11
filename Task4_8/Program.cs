// Перевернуть число
namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            // ищем модуль числа
            int m = 0;
            if (n >= 0)
            {
                m = n;
            }
            else
            {
                m = -n;
            }
            int a = 0;
            int res = 0;
            while (m !=0)
            {
                a = m % 10;  // получаем последнюю цифру в числе
                m /= 10; // получаем новое число (без последней цифры)
                res = res * 10 + a;  // "приставляем" последнюю цифру к результату
            }
            if (n < 0)
            {
               res = -res ;
            }
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}

