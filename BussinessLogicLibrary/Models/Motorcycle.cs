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
        public DateTime? StartTime { get; set; }

        public int Parkingspot { get; set; }

        /// <summary>
        /// Använd ifall du vill ange specifika värden på allt, annars, använd andra kontruktorn
        /// </summary>
        /// <param name="reg"></param>
        /// <param name="startTime"></param>
        /// <param name="size"></param>
        public Motorcycle(string reg, DateTime startTime, int size)
        {
            Registration = reg;
            StartTime = startTime;
            Size = size;
        }

        /// <summary>
        /// Standardvärden, DateTime=DateTime.Now och Size=2
        /// </summary>
        /// <param name="reg"></param>
        public Motorcycle(string reg)
        {
            Registration = reg;
        }

        public Motorcycle()
        {

        }
    }
   
}
