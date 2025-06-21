namespace Task_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] objects = new IFlyable[]
            {
                    new Bird(15),
                    new Airplane(5000,20),
                    new Bird(500),
                    new Airplane (1000,150)
            };
            foreach (var obj in objects)
            {
                obj.Fly();
            }
            Console.ReadKey();

        }

        public interface IFlyable
        {
            void Fly();
            int MaxAltitude { get; }
        
        }

        public class Bird : IFlyable
        {
            public int MaxAltitude { get; }
            public Bird(int alt)
            {
                MaxAltitude = alt;

            }
            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");

            }
        }
        public class Airplane : IFlyable
        {
            public int MaxAltitude { get; }
            public int CountPassengers { get; }
            public Airplane(int alt, int countpas)
            {
                MaxAltitude = alt;
                CountPassengers = countpas;
            }
            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров, везу {CountPassengers} пассажиров");

            }
        }
    }
}
