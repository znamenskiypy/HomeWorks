namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book kniga = new Book("Сказки", "Пушкин", 1987, 204);
            kniga.GetInfo();
            Console.ReadKey();
        }

        public class Book
        { 
            private string _title;
            private string _author;


            public int Year { get; set; }
            public int Pages { get; set; }
            
            public string Title
            {
                set
                {
                    _title = value;
                }
                get
                {
                    return _title;
                }
            }
            public string Author
            {
                set
                {
                    _author = value;
                }
                get
                {
                    return _author;
                }
            }


            public Book(string title, string author, int year, int pages)   // Конструктор
            {
                Title = title;
                Author = author;
                Year = year;
                Pages = pages;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Название: {Title}, автор: {Author}, год издания: {Year}, страниц: {Pages}.");
            }

        }
    }
}
