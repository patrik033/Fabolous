﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    class Car : IVehicle
    {
        public int Size { get; set; } = 4;
        public string Registration { get; set; }
        public DateTime StartTime { get; set; }
    }
}
