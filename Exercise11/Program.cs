using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VehicleData V = new VehicleData();
            Bicycle B = new Bicycle("Carbon");
            Car C = new Car("V8", "Honda", false);
            V.PrintVehicle(C);
            C.StartEngine();
            V.PrintVehicle(C);
            V.PrintVehicle(B);
            Console.ReadKey();
        }
    }
}
