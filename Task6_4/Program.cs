using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?: ");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько тебе лет?: ");
            string age = Console.ReadLine();

            Console.WriteLine("Откуда ты?: ");
            string city = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Имя: {0}, Возраст: {1}, Город: {2}", name, age, city);
            Console.WriteLine(sb);

            Console.ReadKey();

        }
    }
}
