using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    interface IGarage
    {
        void AddCar(Car car);
        void TakeOutCar(Car car);
        bool FixCar(Car car);
     
    }
}
