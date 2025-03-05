//описать число словами
namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999:");
            int n = Convert.ToInt32(Console.ReadLine());
            string hundreds = "";
            string decades = "";
            string units = "";
            if (n < 100 || n > 999)
                {
                Console.WriteLine("Некорректное число!");
            }
            else
            {
                if (n / 100 == 1)  //считаем сотни
                {
                    hundreds = "сто";
                }
                else if (n / 100 == 2)
                {
                    hundreds = "двести";
                }
                else if (n / 100 == 3)
                {
                    hundreds = "триста";
                }
                else if (n / 100 == 4)
                {
                    hundreds = "четыреста";
                }
                else if (n / 100 == 5)
                {
                    hundreds = "пятьсот";
                }
                else if (n / 100 == 6)
                {
                    hundreds = "шестьсот";
                }
                else if (n / 100 == 7)
                {
                    hundreds = "семсот";
                }
                else if (n / 100 == 8)
                {
                    hundreds = "восемсот";
                }
                else if (n / 100 == 9)
                {
                    hundreds = "девятьсот";
                }

                if (n % 100 == 10)  //считаем десятки
                {
                    decades = "десять";
                }
                else if (n % 100 == 11)
                {
                    decades = "одиннадцать";
                }
                else if (n % 100 == 12)
                {
                    decades = "двенадцать";
                }
                else if (n % 100 == 13)
                {
                    decades = "тринадцать";
                }
                else if (n % 100 == 14)
                {
                    decades = "четырнадцать";
                }
                else if (n % 100 == 15)
                {
                    decades = "пятнадцать";
                }
                else if (n % 100 == 16)
                {
                    decades = "шестнадцать";
                }
                else if (n % 100 == 17)
                {
                    decades = "семнадцать";
                }
                else if (n % 100 == 18)
                {
                    decades = "восемнадцать";
                }
                else if (n % 100 == 19)
                {
                    decades = "девятнадцать";
                }
                else if (n % 100 - (n % 10) == 20)
                {
                    decades = "двадцать";
                }
                else if (n % 100 - (n % 10) == 30)
                {
                    decades = "тридцать";
                }
                else if (n % 100 - (n % 10) == 40)
                {
                    decades = "сорок";
                }
                else if (n % 100 - (n % 10) == 50)
                {
                    decades = "пятьдесят";
                }
                else if (n % 100 - (n % 10) == 60)
                {
                    decades = "шестьдесят";
                }
                else if (n % 100 - (n % 10) == 70)
                {
                    decades = "семдесят";
                }
                else if (n % 100 - (n % 10) == 80)
                {
                    decades = "восемдесят";
                }
                else if (n % 100 - (n % 10) == 90)
                {
                    decades = "девяносто";
                }

                if (n % 10 == 1 && decades != "одиннадцать")    //считаем единицы
                {
                    units = "один";
                }
                else if (n % 10 == 2 && decades != "двенадцать")
                {
                    units = "два";
                }
                else if (n % 10 == 3 && decades != "тринадцать")
                {
                    units = "три";
                }
                else if (n % 10 == 4 && decades != "четырнадцать")
                {
                    units = "четыре";
                }
                else if (n % 10 == 5 && decades != "пятнадцать")
                {
                    units = "пять";
                }
                else if (n % 10 == 6 && decades != "шестнадцать")
                {
                    units = "шесть";
                }
                else if (n % 10 == 7 && decades != "семнадцать")
                {
                    units = "семь";
                }
                else if (n % 10 == 8 && decades != "восемнадцать")
                {
                    units = "восемь";
                }
                else if (n % 10 == 9 && decades != "девятнадцать")
                {
                    units = "девять";
                }
            }

            Console.WriteLine(hundreds + " " + decades + " " + units);
            Console.ReadKey();
        }
    }
}
