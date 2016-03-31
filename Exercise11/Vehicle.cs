using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    abstract class Vehicle
    {
        public string TypeOfVehicle { get; set; }

        public Vehicle(string _typeOfVehicle)
        {
            TypeOfVehicle = _typeOfVehicle;
        }
        public virtual string DescribeVehicle()
        {
            return ("This is an: " + TypeOfVehicle); 
        }

    }
}
