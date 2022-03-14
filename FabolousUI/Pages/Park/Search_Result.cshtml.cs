using BussinessLogicLibrary;
using BussinessLogicLibrary.Models;
using BussinessLogicLibrary.Stuff;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Newtonsoft.Json;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class Search_Result : PageModel
    {
        
        private readonly FabolousDbContext _context;
        
        
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        
        public Parking_Garage Garage;
        public JsonEditor jsonEditor = new JsonEditor();
        public Garage_Functions GarageFunctions;
        
        public List<Vehicle> Vehicles = new List<Vehicle>();
        



        public List<Vehicle> SearchForVehicles()
        {
           List<Vehicle> vehicles = new List<Vehicle>();

            foreach (var vehicle in _context.cars.Where(x => x.Registration.Contains(Search)))
            {
                vehicles.Add((Vehicle)vehicle);
            }
            foreach (var vehicle in _context.motorcycles.Where(x => x.Registration.Contains(Search)))
            {
                vehicles.Add((Vehicle)vehicle);
            }

            return vehicles;

        }




        public Search_Result(FabolousDbContext context)
        {
            _context = context;
            GarageFunctions = new Garage_Functions(_context);

        }
        
        
        public void OnGet()
        {
            Garage = GarageFunctions.InstanciateGarage(int.Parse(jsonEditor.ReadProperty("Parkinggarage", "Size")));
            Garage = GarageFunctions.GetParkedVehicles(Garage);
            
            Vehicles = SearchForVehicles();
            

        }

        public void OnPost(Dictionary<string, string> name)
        {

        }
        
    }
}
