using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Dts
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDT _repodt;
        public IEnumerable<DT> directoresTecnicos { get; set; }
        public IndexModel(IRepositorioDT repodt)
        {
        _repodt = repodt;
        }

        public void OnGet()
        {
            directoresTecnicos = _repodt.GetAlldT();
        }
    }
}
