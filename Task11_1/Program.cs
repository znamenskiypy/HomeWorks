namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog(),
                new Cat(),
                new Dog(),
                new Dog(),
                new Cat(),
            };
            foreach (var animal in animals)
                Console.WriteLine(animal.ShowInfo());
            
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Sound();
        public string ShowInfo()
        {
            return Name + " " + this.Sound();
        }

    }
    public class Dog : Animal
    {
        public override string Name => "Собака";
        public override string Sound()
        {
            return "Гав";
        }
    }
    public class Cat : Animal
    {
        public override string Name => "Кошка";
        public override string Sound()
        {
            return "Мяу";
        }
    }
}
