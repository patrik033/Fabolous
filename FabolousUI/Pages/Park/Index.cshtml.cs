using BussinessLogicLibrary;
using BussinessLogicLibrary.Stuff;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class IndexModel : PageModel
    {
       

        private readonly FabolousDbContext _context;

        public IList<Parkingspot> Cars { get; set; }
        private Car[] cars { get; set; }

        //page number variable
        [BindProperty(SupportsGet = true)]
        public int P { get; set; } = 1;

        //page size variable
        [BindProperty(SupportsGet = true)]
        public int S { get; set; } = 50;
        public int TotalRecords { get; set; } = 0;
        public List<object> FoundVehicles { get; set; } = new List<object>();
        public int StoredVehicles { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public Parking_Garage Garage;
        public Garage_Functions GarageFunctions;
        public JsonEditor jsonEditor = new JsonEditor();
        public Vehicle_Management vm = new Vehicle_Management();
        public IndexModel(FabolousDbContext context)
        {
            _context = context;
            GarageFunctions = new Garage_Functions(_context);
        }

        public IActionResult Test()
        {
            if (Search != null)
            {
                FoundVehicles = vm.SearchButtonListGenerator(Search).ToList();
                return Page();
            }
            else
                return Page();
        }


        public IActionResult OnGet()
        {
           

            Garage = GarageFunctions.InstanciateGarage(int.Parse(jsonEditor.ReadProperty("Parkinggarage","Size")));
            Garage = GarageFunctions.GetParkedVehicles(Garage);
            
            TotalRecords = Garage.spots.Count();

            if (TotalRecords < GarageFunctions.GetHighestParkingSpot())
            {
                return RedirectToPage("../WrongParkingSpotCount");

            }

            Garage.spots = Garage.spots.Skip((P-1) * S).Take(S).ToList();

            Cars = Garage.spots
                .Skip((P - 1) * S)
                .Take(S)
                .ToList();

            return Page();
        }
        public IActionResult OnPost()
        {
            return Page();
        }

    }
}
