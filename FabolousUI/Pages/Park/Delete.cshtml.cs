using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Car myCar { get; set; } = new Car();


        public DeleteModel(FabolousDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            myCar = _context.cars.FirstOrDefault(c => c.Id == id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            var category = await _context.cars.FindAsync(id);
            if (category != null)
            {
                _context.cars.Remove(category);
                await _context.SaveChangesAsync();
            }
            TempData["Success"] = "Vehicle deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
