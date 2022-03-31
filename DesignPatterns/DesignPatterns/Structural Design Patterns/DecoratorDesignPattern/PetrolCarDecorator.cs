using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.DecoratorDesignPattern
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car)
            : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            _car.ManufactureCar();
            AddEngine(_car);
            return _car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMW)
            {
                BMW BMWCar = (BMW) car;
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}
