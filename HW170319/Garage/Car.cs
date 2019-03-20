using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Car
    {
        public string Brand { get;private set; }
        public bool TotalLost { get;private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            if (totalLost || !needsRepair)
            {
                throw new RepairMismatchException();
            }
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
        }
    }
}
