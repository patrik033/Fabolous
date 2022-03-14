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


            if (ModelState.IsValid)
            {
                //kollar efter dubletter
                var fromCar = _context.cars.Where(x => x.Registration == myCar.Registration).FirstOrDefault();
                var fromMc = _context.motorcycles.Where(x => x.Registration == myCar.Registration).FirstOrDefault();
                if (fromCar == null && fromMc == null)
                {
                    myCar.Registration = myCar.Registration.ToUpper();
                    await _context.cars.AddAsync(myCar);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Car created successfully";
                    return RedirectToPage("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "The registration number already exists, please enter a different one");
                }
            }
            return Page();

        }
    }
}
