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
    public class SearchResult : PageModel
    {
        
        private readonly FabolousDbContext _context;
        
        
        

        public IEnumerable<Parkingspot> myNum;
        public ParkingGarage Garage;

        public GarageFunctions GarageFunctions;

        public List<object> FoundVehicles { get; set; }

        public SearchResult(FabolousDbContext context)
        {
            _context = context;
           
          
        }
        
        
        public IActionResult OnGet(Dictionary<string, string> foundVehicles)
        {
            if (foundVehicles != null && foundVehicles.Count != 0)
            {
                foreach (var vehicle in foundVehicles)
                {
                    FoundVehicles.Add(JsonConvert.DeserializeObject(vehicle.Value));
                }
                return Page();
            }
            else
                return RedirectToPage("Index");
           
               
        }
    }
}
