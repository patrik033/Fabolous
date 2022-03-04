using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class EditModel : PageModel
    {

        private readonly FabolousDbContext _context;
        public Car myCar { get; set; } = new Car();

        public EditModel(FabolousDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            myCar = _context.cars.FirstOrDefault(c => c.Id == id);
        }

        //public async Task<IActionResult> OnPost()
        //{
        //    _context.cars.Update(myCar);
        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("Index");
        //}


    }
}
