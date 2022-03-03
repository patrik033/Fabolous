﻿using System;
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
        public DateTime StartTime { get; set; }
        public int Size { get; set; }
    }
}
