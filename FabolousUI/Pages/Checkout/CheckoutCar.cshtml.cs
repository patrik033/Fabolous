using BussinessLogicLibrary;
using BussinessLogicLibrary.Stuff;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Checkout
{
    public class IndexModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Car myCar { get; set; } = new Car();

        public string NiceTime { get; set; }
        public TimeSpan ParkedTime { get; set; }
        public JsonEditor Editor { get; set; }
        public CostCalculation CostCalculator { get; set; }
        public string Cost { get; set; }
        public decimal TotalCost { get; set; }
        public string NiceValue { get; set; }
        public string TextString { get; set; }

        public IndexModel(FabolousDbContext context)
        {
            ParkedTime = new TimeSpan();
            _context = context;
            CostCalculator = new CostCalculation();
            Editor = new JsonEditor();
        }

        public void OnGet(int id)
        {
            myCar = _context.cars.FirstOrDefault(c => c.Id == id);
            Cost = Editor.ReadProperty("Car", "Cost");
            ParkedTime = CostCalculator.ParkedTime(myCar.StartTime);
            NiceTime = CostCalculator.ParkedTimeToScreen(myCar.StartTime);
            TotalCost = CostCalculator.CalculateCost(myCar.StartTime, int.Parse(Cost));
            NiceValue = TotalCost.ToString("C2");
            TextString = $"\nParkerad tid:   {NiceTime} \n" +
                $"Total kostnad:   {NiceValue}";
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            var category = await _context.cars.FindAsync(id);
            if (category != null)
            {
                _context.cars.Remove(category);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Vehicle deleted successfully";
                return RedirectToPage("../Park/Index");
            }
            else
            {
                TempData["error"] = "Vehicle not found";
                return Page();
            }
        }
    }
}
