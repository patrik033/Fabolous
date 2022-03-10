using BussinessLogicLibrary;
using BussinessLogicLibrary.Stuff;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class Rerout_IndexModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public IList<Parkingspot> Cars { get; set; }
        private Car car { get; set; }

        public Motorcycle Mc { get; set; }

        //page number variable
        [BindProperty(SupportsGet = true)]
        public int P { get; set; } = 1;

        //page size variable
        [BindProperty(SupportsGet = true)]
        public int S { get; set; } = 50;
        public int TotalRecords { get; set; } = 0;
        
        public int StoredVehicles { get; set; }
        public object MyVehicle { get; set; }
        public Parking_Garage Garage;
        public Garage_Functions GarageFunctions;
        public JsonEditor jsonEditor = new JsonEditor();

        public Rerout_IndexModel(FabolousDbContext context)
        {
            _context = context;
            GarageFunctions = new Garage_Functions(_context);
        }
        public IActionResult OnGet(string passedObject)
        {

            MyVehicle = JsonConvert.DeserializeObject<Motorcycle>(passedObject);
            MyVehicle = JsonConvert.DeserializeObject<Car>(passedObject);
            if (MyVehicle == typeof(Motorcycle))
            {
                return NotFound();
            }
            else if (MyVehicle == typeof(Car))
            {
                return NotFound();
            }  
            /*foreach(var item in d)
            {
                MyVehicle=item.Value;
            }*/
            

            Garage = GarageFunctions.InstanciateGarage(int.Parse(jsonEditor.ReadProperty("Parkinggarage","Size")));
            Garage = GarageFunctions.GetParkedVehicles(Garage);
            
            TotalRecords = Garage.spots.Count();

            if (TotalRecords < GarageFunctions.GetHighestParkingSpot(Garage))
            {
                return RedirectToPage("../WrongParkingSpotCount");

            }

            Garage.spots = Garage.spots.Skip((P-1) * S).Take(S).ToList();

            
            return Page();
        }
       
    }
}
