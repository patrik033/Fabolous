using BussinessLogicLibrary;
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
        public List<Parking_Garage>[] InstanciateGarage(int garageSize)
        {
            List<Parking_Garage>[] parkingGarage = new List<Parking_Garage>[garageSize];
            return parkingGarage;
        }
        /// <summary>
        /// Hämtar fordon från databasen och sätter in dom i en redan instansierad lista.o
        /// </summary>
        /// <param name="garage"></param>
        /// <returns></returns>
        /// 


        //public Parking_Garage GetParkedVehicles(Parking_Garage garage)
        //{
        //    foreach (var vehicle in _db.cars)
        //    {
        //        if (vehicle.Parkingspot != null && vehicle.Parkingspot != 0 && vehicle.Size <= (garage.Parkingspots[vehicle.Parkingspot-1].Size))
        //        {
        //            garage.Parkingspots[vehicle.Parkingspot - 1].Parked_Vehicles.Add(vehicle.Registration, vehicle);
        //            garage.Parkingspots[vehicle.Parkingspot - 1].Size -= vehicle.Size; 
        //        }
        //    }
        //    foreach (var vehicle in _db.motorcycles)
        //    {
        //        if (vehicle.Parkingspot != null && vehicle.Parkingspot != 0 && vehicle.Size <= garage.Parkingspots[vehicle.Parkingspot - 1].Size)
        //        {
        //            garage.Parkingspots[vehicle.Parkingspot - 1].Parked_Vehicles.Add(vehicle.Registration, vehicle);
        //            garage.Parkingspots[vehicle.Parkingspot - 1].Size -= vehicle.Size;
        //        }
        //    }
        //    return garage;
        //}


        //public Parking_Garage GetParking(List<Parking_Garage>[] parkingGarage)
        //{
        //    //foreach (var vehicle in _db.cars)
        //    //{
        //    //    if(vehicle.Parkingspot != null && vehicle.Parkingspot != 0 && vehicle.Size <= garage.Parkingspots.Size)
        //    //    {
        //    //        if(garage.Parkingspots)
        //    //    }
        //    //}

        //    //for (int i = 0; i < garage; i++)
        //    //{

        //    //}
        //}
    }
}
