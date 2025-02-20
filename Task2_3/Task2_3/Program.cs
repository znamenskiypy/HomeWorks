//дюймы в метры
namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(Console.ReadLine());

            double lengthMm = length * 25.4;
            
            double m = Math.Floor(lengthMm / 1000);
            double cm = Math.Floor((lengthMm - m * 1000)/10);
            double mm = Math.Round(lengthMm -m * 1000-cm * 10, 2);


            Console.WriteLine("{0} метров, {1} сантиметров, {2} миллиметров",m, cm, mm);
            Console.ReadKey();
        }
    }
}
