using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.EditTypes
{
    [BindProperties]
    public class EditMotorcykleModel : PageModel
    {



        private readonly FabolousDbContext _context;
        public Motorcycle myMc { get; set; } = new Motorcycle();

        public EditMotorcykleModel(FabolousDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            myMc = _context.motorcycles.FirstOrDefault(c => c.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                _context.motorcycles.Update(myMc);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Motorcykle edited successfully";
                return RedirectToPage("../Park/Index");
            }
            return Page();
        }
    }
}
