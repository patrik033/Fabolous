using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FabolousUI.Pages.Park
{
    public class CreateModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Car myCar { get; set; }

        public CreateModel(FabolousDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _context.cars.AddAsync(myCar);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
