using System.Threading.Tasks;

namespace Task16_1
{
    internal class Program
    {

        static int[] GenerateArray(int size)
        {
            Console.WriteLine("Создаем массив:");
            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 10);
                Console.WriteLine($"{array[i]} ");
                Thread.Sleep(500);
            }
            return array;

        }

        static double GetAverage(int[] array)
        {
            Console.WriteLine("Вычисляем среднее:");
            int sum = 0;
            double avg;
            foreach (int num in array)
            {
                sum += num;
            }
            Thread.Sleep(500);

            avg = Convert.ToDouble(sum) / array.Length;

            return avg;

        }

        static async Task<int[]> GenerateArrayAsync()
        {
            return await Task.Run(() => GenerateArray(10));

        }
        static async Task<double> GetAverageAsync(int[] array)
        {

            return await Task.Run(() => GetAverage(array));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("------Задачи продолжения------");

            Task<int[]> task1 = Task.Run(() => GenerateArray(10));
            Task<double> task2 = task1.ContinueWith(t =>
            {
                int[] array = t.Result;
                return GetAverage(array);
            });
            Console.WriteLine($"{task2.Result}");

            Console.WriteLine("------Асинхронное выполнение------");

            //int[] res = GenerateArrayAsync().Result;
            double avg = GetAverageAsync(GenerateArrayAsync().Result).Result;
            Console.WriteLine(avg);



            Console.ReadKey();
        }
    }
}