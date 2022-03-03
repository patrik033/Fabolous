using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    public class IndexModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public IEnumerable<Car> Cars { get; set; }

        public IndexModel(FabolousDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Cars = _context.cars;
        }
    }
}
