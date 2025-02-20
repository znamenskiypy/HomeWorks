//градусы в радианы
namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degs = Convert.ToInt32(Console.ReadLine());
            int mins = Convert.ToInt32(Console.ReadLine());
            int secs = Convert.ToInt32(Console.ReadLine());

            degs = degs % 360;   // если угол больше 360

            int totalSecs = mins * 60 + secs;    //считаем общее число секунд
            double secsToFrac = totalSecs/3600.0;  // переводим секунды в доли градуса
            double degs_dec = degs + secsToFrac;   //считаем градусы с долями

            double rad = degs_dec * Math.PI/180; 

            

            Console.WriteLine(rad);
            Console.ReadKey();
        }
    }
}
