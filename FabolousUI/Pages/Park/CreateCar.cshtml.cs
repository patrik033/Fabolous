using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public Car myCar { get; set; } = new Car();
        public int Id { get; set; }

        public CreateModel(FabolousDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Id = id;
        }

        public async Task<IActionResult> OnPost()
        {
            //TODO add toaster for both create car and create mc

            if (ModelState.IsValid)
            {
                await _context.cars.AddAsync(myCar);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Car created successfully";
                return RedirectToPage("Index");
            }
           return Page();

        }
    }
}
