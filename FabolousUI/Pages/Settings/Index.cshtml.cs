using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FabolousUI.Pages.Settings
{
    public class IndexModel : PageModel
    {
       public BussinessLogicLibrary.Stuff.JsonEditor jsonEditor = new BussinessLogicLibrary.Stuff.JsonEditor();
       public string configText;

        [BindProperty]
        public string Property { get; set; }
        [BindProperty]
        public string Field { get; set; }
        [BindProperty]
        public int Value { get; set; }

       


        public void OnGet()
        {
            configText = jsonEditor.ReturnAllTextClean();           
        }

        public IActionResult OnPost()
        {
            jsonEditor.EditProperty(Field, Property, Value);
            return RedirectToPage("Index");                                    
        }
        
    }
}
