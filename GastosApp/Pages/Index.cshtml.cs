using GastosApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GastosApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Spent> Gastos => AddModel.Bills; 
        public decimal Capital { get; set; } = 10000;
        public void OnGet()
        {
            Capital -= Gastos.Sum(g => g.Monto);
        }
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        

    }


}
