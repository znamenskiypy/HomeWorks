namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            int[] invArray = new int[n];
            Random rnd = new Random();

            // Создаем массив
            int y = n - 1;
            for (int i = 0; i < n; i++)   
            {
                int rNum = rnd.Next(0, 11);
                array[i] = rNum;
                Console.Write("{0} ", array[i]);
                // Записываем значения во второй массив в обратном порядке
                invArray[y] = rNum;
                y--;
            }
            Console.WriteLine();

            // Выводим перевернутый массив
            foreach (int a in invArray)
            {
                Console.Write("{0} ", a);
            }

            Console.ReadKey();


        }
    }
}
