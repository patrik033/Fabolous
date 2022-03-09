using BussinessLogicLibrary;
using BussinessLogicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary
{
    public class Garage_Functions
    {

        private readonly FabolousDbContext _db;
        public Garage_Functions(FabolousDbContext db)
        {

            _db = db;
        }

        /// <summary>
        /// Ska skicka tillbaka en en tom lista på alla parkeringsplatser som garaget kan använda sig av. Indatan är antal platser som garaget ska ha
        /// </summary>
        /// <param name="garageSize"></param>
        /// <returns></returns>
        public Parking_Garage InstanciateGarage(int size)
        {
            Parking_Garage garage = new Parking_Garage();

            for (int i = 0; i < size; i++)
            {
                garage.spots.Add(new Parkingspot());
            }

            int num = 1;

            foreach (var item in garage.spots)
            {
                item.Id = num;
                num++;
            }
            return garage;
        }
        /// <summary>
        /// Hämtar fordon från databasen och sätter in dom i en redan instansierad lista.o
        /// </summary>
        /// <param name="garage"></param>
        /// <returns></returns>
        /// 


        public Parking_Garage GetParkedVehicles(Parking_Garage parkingGarage)
        {


            foreach (var item in parkingGarage.spots)
            {
                var number = item.Id;
                var selectedItem = _db.cars.Where(car => car.Parkingspot == number).FirstOrDefault();
                item.Parked_Vehicles.Add(selectedItem);
                item.CurrentSize += 4;
            }

            foreach (var item in parkingGarage.spots)
            {
                var number = item.Id;
                var selectedItem = _db.motorcycles.Where(car => car.Parkingspot == number).FirstOrDefault();
                item.Parked_Vehicles.Add(selectedItem);
                item.CurrentSize += 2;
            }
            return parkingGarage;


            //foreach (var vehicle in _db.cars)
            //{
            //    if (vehicle.Parkingspot != null && vehicle.Parkingspot != 0 && vehicle.Size <= garage.spots[vehicle.Parkingspot - 1].Size)
            //    {
            //        if(parkingGarage.spots)

            //        //parkingGarage.[vehicle.Parkingspot - 1].Parked_Vehicles.Add(vehicle.Registration, vehicle);
            //        //garage.Parkingspots[vehicle.Parkingspot - 1].Size -= vehicle.Size;
            //    }
            //}
            //foreach (var vehicle in _db.motorcycles)
            //{
            //    if (vehicle.Parkingspot != null && vehicle.Parkingspot != 0 && vehicle.Size <= garage.Parkingspots[vehicle.Parkingspot - 1].Size)
            //    {
            //        garage.Parkingspots[vehicle.Parkingspot - 1].Parked_Vehicles.Add(vehicle.Registration, vehicle);
            //        garage.Parkingspots[vehicle.Parkingspot - 1].Size -= vehicle.Size;
            //    }
            //}
            //return garage;
        }
    }
}
