using System.Text;
namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string input = Console.ReadLine();
            string sentence = input.Replace(" ", "").ToLower();
   
            StringBuilder reversed = new StringBuilder();

            foreach (char letter in sentence)
            {
                reversed.Insert(0, letter.ToString());
            }

            if (sentence == reversed.ToString())
            {
                Console.WriteLine("Это предожение - палиндром");
            }
            else 
            {
                Console.WriteLine("Это предожение - не палиндром");
            }

            Console.ReadKey();


        }
    }
}
