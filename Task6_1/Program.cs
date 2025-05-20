using System.Text;
namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            string longestWord = " ";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

            }

            Console.WriteLine("Самое длинное слово в предложении - {0}", longestWord);
            Console.ReadKey();


        }
    }
}
