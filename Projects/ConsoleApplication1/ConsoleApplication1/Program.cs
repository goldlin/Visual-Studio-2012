using System;

namespace ConsoleApplication1
{
    public enum Days
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Red");
            ChangeCarColor(car);
            Console.WriteLine(car.Describe());
            Console.ReadKey();
        }

        private static void ChangeCarColor(Car car)
        {
            car.Color = "Green";
        }
    }

    struct Car
    {
        private string _color;

        public Car(string color)
        {
            _color = color;
            Console.WriteLine("Constructor with color parameter called!");
        }

        public string Describe()
        {
            return string.IsNullOrEmpty(_color) ? "No color!" : "This car is " + Color;
        }

        public string Color
        {
            get { return _color.ToUpper(); }
            set {
                if (value == "Red") _color = value;
                else
                {
                    _color = value;
                    Console.WriteLine("This car most fits RED");
                }
            }
        }
    }
}
