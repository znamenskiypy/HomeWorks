using System.Text;
namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = "сентябрь";
            int year = 1995; 
            double total_sum = 28732.35;
            int count = 831;
            double avg = total_sum / count;

            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Отчет о продажах за {0} {1}", month, year);
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Общая сумма продаж : {0}",string.Format("{0:N2}", total_sum));
            Console.WriteLine("Количество проданных товаров : {0}", count);
            Console.WriteLine("Средняя стоимость товара : {0}", string.Format("{0:.00}", avg));

            Console.ReadKey();


        }
    }
}
