namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            double c = 6.3;
            double d = 3.5;

            int res1 = Multiply(a, b);
            double res2 = Multiply(c, d);

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();
        }

        static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
    }
}
