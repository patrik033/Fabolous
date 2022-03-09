using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Checkout
{
    public class CheckoutMotorcykleModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Motorcycle myCar { get; set; } = new Motorcycle();


        public CheckoutMotorcykleModel(FabolousDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            myCar = _context.motorcycles.FirstOrDefault(c => c.Id == id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            var category = await _context.motorcycles.FindAsync(id);
            if (category != null)
            {
                _context.motorcycles.Remove(category);
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

