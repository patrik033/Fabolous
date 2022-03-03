using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    public class Parkingspot
    {
        public int Size { get; set; } = 4;
        public Dictionary<string, object> Parked_Vehicles { get; set; }
    }
}
