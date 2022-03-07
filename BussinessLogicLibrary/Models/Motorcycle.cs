using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    public class Motorcycle : IVehicle
    {
        public int Id { get; set; }
        public string Registration { get; set; }             
        public int Size { get; set; } = 2;
        public DateTime StartTime { get; set; } = DateTime.Now;

        public int Parkingspot { get; set; }

        
    }
   
}
