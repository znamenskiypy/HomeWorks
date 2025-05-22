using System.Security.Cryptography.X509Certificates;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Building house = new Building("ул.Родительская", 148, -2020);
                house.DisplayInfo();
                house.CalculateTax();
                MultiBuilding childhouse = new MultiBuilding("ул.Дочерняя", 7500, 1995, 16, true);
                childhouse.DisplayInfo();
                childhouse.CalculateTax();

                //Upcasting
                Building parent = childhouse;
                Console.WriteLine("-----После апкастинга-----");
                parent.DisplayInfo();


                //Downcasting
                if (parent is MultiBuilding)
                {
                    MultiBuilding childhouse2 = parent as MultiBuilding;
                    Console.WriteLine("-----После даункастинга-----");
                    childhouse2.DisplayInfo();
                    childhouse2.childMethod();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
            
            
            
            
            Console.ReadKey();

        }

        //Родительский класс
        public class Building
        {
            protected string _address;
            protected double _area;
            protected readonly int _yearBuilt;

            public string Address 
            { 
                get => _address;
                set
                {
                    _address = value;  

                } 
            }
            public double Area
            {
                get => _area;
                set
                {
                    if (value > 10)
                    {
                        _area = value;
                    }
                    else
                    {
                        throw new ArgumentException("Слишком маленькая площадь дома " + this.ToString());
                    }

                }
            }

            public int YearBuilt
            {
                get => _yearBuilt;    
            }

            public int BuildingAge { get; }

           
            public Building(string adr,double area,int year)
            {
                Address = adr;
                Area = area;
                _yearBuilt = year;

                BuildingAge = DateTime.Today.Year - YearBuilt;

            }
            public virtual void CalculateTax()
            {
                double tax = _area * 1000;
                Console.WriteLine($"К оплате: {tax}");
            
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Адрес: {_address}, площадь: {_area}, возраст: {BuildingAge}");
            }

        }

        //Дочерний класс
        public sealed class MultiBuilding : Building
        {
            private int _floors;
            private bool _hasElevator;

            public double AreaPerFloor { get; }

            public MultiBuilding(string adr, double area, int year, int floors, bool elevator = false)
                : base(adr, area, year)
            {
                _floors = floors;
                _hasElevator = elevator;

                    AreaPerFloor = area / floors;
            }

            public override void CalculateTax()
            {
                double tax = 0;
                if (_hasElevator == true)
                    tax = (1 + (_floors - 1) * 0.05) + 5000;
                else
                    tax = (1 + (_floors - 1) * 0.05);
                Console.WriteLine($"К оплате: {tax}");
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Адрес: {_address}, площадь: {_area}, возраст: {BuildingAge}, этажей: {_floors}, лифт: {_hasElevator}");
            }

            public void childMethod()
            {
                Console.WriteLine("--Вызов уникального метода дочернего класса--");

            }
        }

    }
}
