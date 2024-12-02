using GastosApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GastosApp.Pages
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public Spent NewSpent { get; set; }
        public static List<Spent> Bills { get; set; } = new List<Spent>();

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                NewSpent.Id = Bills.Count + 1;
                Bills.Add(NewSpent);
                return RedirectToPage("Index");
            }
            return Page();
        }
        public void OnGet()
        {

        }
    }
}
