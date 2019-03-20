using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Garage:IGarage
    {
        List<Car> cars;
        List<string> carTypes;

        public Garage(List<string> carTypes)
        {
            this.carTypes = carTypes;
        }
        public void AddCar(Car car)
        {

            if (car == null)
            {
                throw new CarNullException("car given was null!");
            }
            if (cars.Contains(car))
            {
                throw new CarAlreadyHereException("car already exist");
            }
            
            if (car.TotalLost == true)
            {
                throw new WeDoNotFixTotalLostException("car is totalos");
            }
            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException("we dont fixing your car type");
            }
            if (!car.NeedsRepair)
            {
                throw new RepairMismatchException("car dont need repair");
            }
                
            cars.Add(car);
        }
        public void TakeOutCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("car given was null!");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException("car not exist");
            }
            if (car.NeedsRepair)
            {
                throw new CarNotReadyException("car need repair");
            }
            cars.Remove(car);
        }
        public bool FixCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("car given was null!");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException("car not exist");
            }
            if (!car.NeedsRepair)
            {
                throw new RepairMismatchException("car dont need repair");
            }
            return car.NeedsRepair = true;
        }

    }
}
