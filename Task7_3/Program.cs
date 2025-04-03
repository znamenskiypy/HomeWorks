namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            PrintNumbers(numbers);
            PrintNumbers(numbers, false);
            PrintNumbers(numbers, true);
            Console.ReadKey();
        }

        static void PrintNumbers(int[] array, bool reverse = false)
        {
            if (reverse == true)
            {
                for (int a = array.Length-1; a >= 0; a--)
                {
                    Console.Write(array[a]);

                }
            }

            else 
            {
                for (int a = 0; a < array.Length; a++)
                {
                    Console.Write(array[a]);
                }
            }
            Console.WriteLine();

        }
    }
}
