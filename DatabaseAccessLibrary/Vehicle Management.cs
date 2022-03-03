﻿using BussinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary
{
    public class Vehicle_Management
    {
        private readonly FabolousDbContext _db;

        public Vehicle_Management(FabolousDbContext db)
        {
            _db = db;
        }
        
        public void RemoveVehicle(string licensePlate, string VehicleType)
        {
            if (VehicleType.ToLower() == "car")
            {
                var vehicle = _db.cars.Where(x => x.Registration == licensePlate).SingleOrDefault();
                _db.cars.Remove(vehicle);
                _db.SaveChanges();

            }
            else if (VehicleType.ToLower() == "motorcycle")
            {
                var vehicle = _db.motorcycles.Where(x => x.Registration == licensePlate).SingleOrDefault();
                _db.motorcycles.Remove(vehicle);
                _db.SaveChanges();
            }

        }

        public List<dynamic> LoadVehicleList(string vehicleType)
        {
            List<dynamic> vehicleList = new List<dynamic>();
            if (vehicleType.ToLower() == "car")
            {               
                vehicleList = (List<dynamic>)_db.cars.Cast<dynamic>();
                return vehicleList;
            }
            else if (vehicleType.ToLower() == "motorcycle")
            {
                vehicleList = (List<dynamic>)_db.motorcycles.Cast<dynamic>();
                return vehicleList;
            }
            return vehicleList;
        }
        
    }
}
