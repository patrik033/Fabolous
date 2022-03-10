using BussinessLogicLibrary;
using BussinessLogicLibrary.Models;
using BussinessLogicLibrary.Stuff;
using DatabaseAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Serialization;

namespace FabolousUI.Pages.Park
{
    [BindProperties]
    public class EditModel : PageModel
    {
        JsonEditor jsonEditor = new JsonEditor();
        private readonly FabolousDbContext _context;
        public Car myCar { get; set; } = new Car();
        public Motorcycle Motorcycle { get; set; } = new Motorcycle();
        public string MyObject { get; set; }

        public IEnumerable<Parkingspot> myNum;
        public Parking_Garage Garage;

        public Garage_Functions GarageFunctions;

      
        public EditModel(FabolousDbContext context)
        {
            _context = context;
            GarageFunctions = new Garage_Functions(_context);
            myNum = new List<Parkingspot>();
        }
        //public void SerializeObject()
        //{
        //    MyObject = jsonEditor.JsonSerializer()
        //}
        
        public void OnGet(int id)
        {
            Garage = GarageFunctions.InstanciateGarage(100);
            Garage = GarageFunctions.GetParkedVehicles(Garage);
            myNum = Garage.spots.Where(x => x.Id == id);
        }
    }
}
