using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона: ");
            string myNumber = Console.ReadLine();

            Regex regex = new Regex(@"^(\+7|8)\(\d{3}\)\d{3}\-\d{2}\-\d{2}$");  

            if (regex.IsMatch(myNumber))
            {
                Console.WriteLine("ok");
            }
            else 
            {
                Console.WriteLine("Выражение {0} имеет неправильный формат!", myNumber);
            }

            Console.ReadKey();
        }
    }
}
