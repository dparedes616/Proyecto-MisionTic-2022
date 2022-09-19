using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Dts
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDT _repoDT;
        public DT dt {get; set;}
        public CreateModel(IRepositorioDT repoDT)
        {
            _repoDT = repoDT;
        }

        public void OnGet()
        {
            dt = new DT();
        }

        public IActionResult OnPost(DT dt)
        {
            _repoDT.AddDT(dt);
            return RedirectToPage("Index");
        }
    }
}
