using BussinessLogicLibrary;
using BussinessLogicLibrary.Models;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class EditModel : PageModel
    {

        private readonly FabolousDbContext _context;
        //public Car myCar { get; set; } = new Car();



        public Parking_Garage Garage;
        public Garage_Functions GarageFunctions;


        public EditModel(FabolousDbContext context)
        {
            _context = context;
            GarageFunctions = new Garage_Functions(_context);
        }
        public void OnGet(int id)
        {
            Garage = GarageFunctions.InstanciateGarage(100);
            Garage = GarageFunctions.GetParkedVehicles(Garage);

            //myCar = _context.cars.FirstOrDefault(c => c.Id == id);
        }

        //public async Task<IActionResult> OnPost()
        //{
        //    _context.cars.Update(myCar);
        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("Index");
        //}


    }
}
