using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.EditTypes
{
    [BindProperties]
    public class EditVehicleModel : PageModel
    {


        private readonly FabolousDbContext _context;
        public Car myCar { get; set; } = new Car();

        public EditVehicleModel(FabolousDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            myCar = _context.cars.FirstOrDefault(c => c.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                _context.cars.Update(myCar);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Car edited successfully";
                return RedirectToPage("../Park/Index");
            }
            return Page();
        }

    }
}
