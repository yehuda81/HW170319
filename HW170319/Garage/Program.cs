using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage(new List<string>() { "honda", "FIAT" });
            //g.AddCar(null);
        }
    }
}
