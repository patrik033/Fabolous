using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class CreateMotorcykleModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Motorcycle myMc { get; set; } = new Motorcycle();

        public CreateMotorcykleModel(FabolousDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            //TODO add toaster for both create car and create mc
            await _context.motorcycles.AddAsync(myMc);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
