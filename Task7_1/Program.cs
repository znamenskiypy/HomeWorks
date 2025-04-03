namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());

            double square1 = Square(a1, b1, c1);
            double square2 = Square(a2, b2, c2);

            if (square1 > square2)
            {
                Console.WriteLine("Первый треугольник ({0}) больше второго ({1})", square1, square2);
            }
            else if (square1 < square2)
            {
                Console.WriteLine("Второй треугольник ({0}) больше первого (1)", square2, square1);
            }
            else 
            {
                Console.WriteLine("Треугольники одинаковые по площади ({0})", square1);
            }

            Console.ReadKey();

        }

        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            //double s = Math.Pow(Convert.ToDouble(p * (p - a) * (p - b) * (p - c)), 0.5);
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
