namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба: ");
            double edgeLength = Convert.ToDouble(Console.ReadLine());
            double volume;
            double surfaceArea;

            CalcCube(edgeLength, out volume, out surfaceArea);
            Console.WriteLine("Объем куба: {0}", volume);
            Console.WriteLine("Площадь поверхности куба: {0}", surfaceArea);

            Console.ReadKey();
        }

        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = edgeLength * edgeLength * edgeLength;
            surfaceArea = edgeLength * edgeLength * 6;
            
        }
    }
}
