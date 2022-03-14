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
                var fromCar = _context.cars.Where(x => x.Registration == myMc.Registration).FirstOrDefault();
                var fromMc = _context.motorcycles.Where(x => x.Registration == myMc.Registration).FirstOrDefault();
                if (fromCar == null && fromMc == null)
                {
                    myMc.Registration = myMc.Registration.ToUpper();
                    _context.motorcycles.Update(myMc);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Motorcykle edited successfully";
                    return RedirectToPage("../Park/Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "The registration number already exists, please enter another one");
                }
            }
            return Page();
        }
    }
}
