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
        public Garage_Functions()
        {

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

            foreach (var spot in parkingGarage.spots)
            {
                if (spot.Size > spot.CurrentSize)
                {
                    var number = spot.Id;
                    if (_db.cars.Where(car => car.Parkingspot == number).Any())
                    {
                        var selectedItem = _db.cars.Where(car => car.Parkingspot == number).FirstOrDefault();
                        if (selectedItem != null && selectedItem.Size <= spot.Size - spot.CurrentSize)
                        {
                            spot.Parked_Vehicles.Add(selectedItem);
                            spot.CurrentSize += 4;
                        }
                    }
                }
            }

            foreach (var spot in parkingGarage.spots)
            {

                if (spot.Size > spot.CurrentSize)
                {
                    var number = spot.Id;

                    if (_db.motorcycles.Where(x => x.Parkingspot == number).Any())
                    {
                        var selectedItem = _db.motorcycles.Where(car => car.Parkingspot == number).Take(2).ToList();
                        foreach (var vehicle in selectedItem)
                        {
                            if (vehicle != null /*&& spot.Size >= vehicle.Size + spot.CurrentSize*/)
                            {
                                spot.Parked_Vehicles.Add(vehicle);
                                spot.CurrentSize += 2;
                            }
                        }
                    }
                }
            }
            return parkingGarage;

        }

        public int GetHighestParkingSpot()
        {
            int Max = 0;

            foreach (var car in _db.cars)
            {
                if (_db.cars != null)
                {

                    if (car.Parkingspot > Max)
                        Max = car.Parkingspot;
                }
            }
            foreach (var mc in _db.motorcycles)
            {
                if (_db.motorcycles != null)
                {

                    if (mc.Parkingspot > Max)
                        Max = mc.Parkingspot;
                }
            }
            return Max;
        }

    }
}
