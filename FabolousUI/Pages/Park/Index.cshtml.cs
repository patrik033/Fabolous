using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly FabolousDbContext _context;
        public IList<Car> Cars { get; set; }
        private Car[] cars { get; set; }

        //page number variable
        [BindProperty(SupportsGet = true)]
        public int P { get; set; } = 1;

        //page size variable
        [BindProperty(SupportsGet = true)]
        public int S { get; set; } = 25;
        public int TotalRecords { get; set; } = 0;



        public IndexModel(FabolousDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            TotalRecords = _context.cars.Count();

            Cars = _context.cars
                .Skip((P - 1) * S)
                .Take(S)
                .ToList();

        }
    }
}
