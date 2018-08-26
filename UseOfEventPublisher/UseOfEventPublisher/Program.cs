using System;

namespace UseOfEventPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCarDealer = new CarDealer();
            var valtteri = new Consumer("Valtteri");
            newCarDealer.NewCarInfo += valtteri.NewCarIsHere;
            newCarDealer.NewCar("Williams");

            var max = new Consumer("Max");
            newCarDealer.NewCarInfo += max.NewCarIsHere;
            newCarDealer.NewCar("Mercedes");
            newCarDealer.NewCarInfo -= valtteri.NewCarIsHere;
            newCarDealer.NewCar("Ferrari");
        }
    }

    public class CarInfoEventArgs : EventArgs
    {
        public CarInfoEventArgs(string car) => Car = car;
        public string Car { get; }
    }

    public class CarDealer 
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;
        public void NewCar (string car)
        {
            Console.WriteLine($"CarDealer, new car {car}");
            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));
        }
    }

    public class Consumer 
    {
        private string _name;
        public Consumer(string name) => _name = name;

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine($"{_name}: car {e.Car} is new");
        }
    }
}
