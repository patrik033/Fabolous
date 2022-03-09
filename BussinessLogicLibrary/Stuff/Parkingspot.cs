using BussinessLogicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    public class Parkingspot
    {
        
        public int Size { get; set; } = 4;  // 0 = Full 2 = Delvis full 4 = Tom
        public int Id { get; set; }
        public int CurrentSize { get; set; } = 0;
        public List<Vehicle> Parked_Vehicles { get; set; } = new List<Vehicle>();
    }
}
