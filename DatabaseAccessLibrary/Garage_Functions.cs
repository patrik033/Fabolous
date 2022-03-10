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

            foreach (var item in parkingGarage.spots)
            {
                if (item.Size > item.CurrentSize)
                {
                    var number = item.Id;
                    if (_db.cars.Where(car => car.Parkingspot == number).Any())
                    {
                        var selectedItem = _db.cars.Where(car => car.Parkingspot == number).FirstOrDefault();
                        if (selectedItem != null && selectedItem.Size <= item.Size - item.CurrentSize)
                        {
                            item.Parked_Vehicles.Add(selectedItem);
                            item.CurrentSize += 4;
                        }
                    }
                }
            }

            foreach (var item in parkingGarage.spots)
            {

                if (item.Size > item.CurrentSize)
                {
                    var number = item.Id;

                    if (_db.motorcycles.Where(x => x.Parkingspot == number).Any())
                    {
                        var selectedItem = _db.motorcycles.Where(car => car.Parkingspot == number).Take(2).ToList();
                        foreach (var lists in selectedItem)
                        {
                            if (lists != null /*&&*/ /*item.Size <= lists.Size *//*- item.CurrentSize*/)
                            {
                                item.Parked_Vehicles.Add(lists);
                                item.CurrentSize += 2;
                            }
                        }
                    }
                }
            }
            return parkingGarage;

        }

        public int GetHighestParkingSpot(Parking_Garage garage)
        {
            int Max = 0;

            foreach (var car in _db.cars)
            {
                if (car.Parkingspot > Max)
                    Max = car.Parkingspot;
            }
            foreach (var mc in _db.motorcycles)
            {
                if (mc.Parkingspot > Max)
                    Max = mc.Parkingspot;
            }
            return Max;
        }

    }
}
