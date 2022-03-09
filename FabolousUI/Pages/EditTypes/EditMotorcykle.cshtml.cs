using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.EditTypes
{
    public class EditMotorcykleModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Motorcycle myCar { get; set; } = new Motorcycle();

        public EditMotorcykleModel(FabolousDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            myCar = _context.motorcycles.FirstOrDefault(c => c.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            _context.motorcycles.Update(myCar);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Vehicle edited successfully";
            return RedirectToPage("Index");
        }
    }
}
