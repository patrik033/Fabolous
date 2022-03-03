using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    class Parkingspot
    {
        public int Size { get; set; } = 4;
        public Dictionary<string, int> Parked_Vehicles { get; set; }
    }
}
