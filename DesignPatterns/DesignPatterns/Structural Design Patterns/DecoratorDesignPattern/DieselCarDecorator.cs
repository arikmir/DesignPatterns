using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.DecoratorDesignPattern
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car)
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
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}