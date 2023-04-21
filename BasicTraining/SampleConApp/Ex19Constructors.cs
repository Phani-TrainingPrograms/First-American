using System;

namespace SampleConApp
{
    class Infotainment
    {
        public string Name { get; set; }

        public void Play() => Console.WriteLine("The {0} Player is playing", Name);
    }

    class Car
    {
        public Infotainment CarInfotainment { get; private set; }

        public Car()
        {
            CarInfotainment = new Infotainment();
            CarInfotainment.Name = "HONDA";
            Console.WriteLine("The Car is created with default Infotainment");
        }
        public Car(Infotainment infotainment)
        {
            CarInfotainment = infotainment;
            Console.WriteLine("The Car is created with newly added Infotainment");
        }
        public virtual void Run()
        {
            if(CarInfotainment != null)
            CarInfotainment.Play();
            Console.WriteLine("Car has started to Run");
        }
    }

    class BMW : Car
    {
        public BMW() : base(new Infotainment { Name = "BMW Infotainment" })
        {

        }
        public override void Run()
        {
            base.Run();
            Console.WriteLine("BMW Car is running now!!!");
        }
    }
    class Ex19Constructors
    {
        static void Main(string[] args)
        {
            //constructorExample();
            constructorChainingExample();
        }

        private static void constructorChainingExample()
        {
            BMW car = new BMW();
            car.Run();
        }

        private static void constructorExample()
        {
            Infotainment infotainment = new Infotainment();
            infotainment.Name = "JBL";
            Car car = new Car();
            car.Run();
            infotainment.Name = "SONY";
            car = new Car(infotainment);
            car.Run();
        }
    }
}
