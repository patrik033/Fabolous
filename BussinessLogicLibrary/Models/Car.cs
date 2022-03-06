using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    public class Car : IVehicle
    {
        public int Id { get; set; }
        public int Size { get; set; } = 4;
        public string Registration { get; set; }
        public DateTime? StartTime { get; set; }

        public int Parkingspot { get; set; }

        public Car(int size,string registration,int parkingSpot)
        {
            Size = size;
            Registration = registration;
            Parkingspot = parkingSpot;
        }

        public Car()
        {

        }
    }
}
