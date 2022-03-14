using BussinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary
{
    public class VehicleManagement
    {
        private readonly FabolousDbContext _db;

        public VehicleManagement(FabolousDbContext db)
        {
            _db = db;
        }
        public Vehicle_Management()
        {

        }
        /// <summary>
        /// Skall ta bort ett fordon baserat på reg nummer. Söksträngen måste vara komplett, annars tas inget bort.
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="VehicleType"></param>
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
        /// <summary>
        /// Skall retunera en lista med alla objekt från databasen. Vilket avgörs utav indatan, i detta fall fordonstypen.
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Ska returnera platserna där en registrerings skylt passar, metoden använder Regex så sökningen behöver inte vara komplett. Skicka in Listan på parkeringsplatserna från garaget. 
        /// </summary>
        /// <param name="currentSearch"></param>
        /// <param name="parkingSpotList"></param>
        /// <returns></returns>
        public List<int> SearchForLicensePlate(string currentSearch, List<Parkingspot> parkingSpotList)
        {
            List<int> indexes = new List<int>();
            Regex regex = new Regex(@$"(\w+)?{currentSearch}(\w+|\d+|\s)?");
            int count = 0;
            foreach(var item in parkingSpotList)
            {
                if (regex.IsMatch(item.GetType().GetProperty("Registration").GetValue(item).ToString()))
                {
                    indexes.Add(count);
                }
                count++;
            }
            return indexes;
        }
        
        /// <summary>
        /// Metod för att generera en lista baserat på inparameter från
        /// Sök lådan 
        /// </summary>
        /// <param name="regNumber"></param>
        /// <returns></returns>
        public IEnumerable<object> SearchButtonListGenerator(string regNumber)
        {         
                var vehicleList = new List<object>();   
                var mcQ =  _db.motorcycles.Where(x => x.Registration.Contains(regNumber)).ToList();
                var carQ = _db.cars.Where(x => x.Registration.Contains(regNumber)).ToList();
                /*if (mcQ == null)
                {
                    list.Add(item);
                }
                if (_db.cars.Where(x => x.Registration.Contains(regNumber)).Any())
                foreach (var item in _db.motorcycles.Where(x => x.Registration.Contains(regNumber)))
                {
                    return mcQ;
                }*/
                vehicleList.AddRange(mcQ);
                vehicleList.AddRange(carQ);
                return vehicleList;
        }
        /// <summary>
        /// Metod för att uppdatera fältet Parkingspot på det fordon som har
        /// flyttats
        /// </summary>
        /// <param name="currentObjectRegistration"></param>
        /// <param name="newSpot"></param>
        public void UpdateMovedVehicle(string currentObjectRegistration, int newSpot)
        {
            var findMc = _db.motorcycles.Find(currentObjectRegistration);
            var findCar = _db.cars.Find(currentObjectRegistration);
            if (findMc == null)
            {
                //uppdatera bil
                findCar = new Car { Parkingspot = newSpot };
                _db.cars.Attach(findCar).Property(x => x.Parkingspot).IsModified = true;
                _db.SaveChanges();
            }
            else if (findCar == null)
            {
                //uppdatera mc
                findMc = new Motorcycle { Parkingspot = newSpot };
                _db.motorcycles.Attach(findMc).Property(x => x.Parkingspot).IsModified = true;
                _db.SaveChanges();
            }
        }
    }
}
