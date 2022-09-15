using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Equipos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _repoequipo;
        public IEnumerable<Equipo> equipos { get; set; }
        public IndexModel(IRepositorioEquipo repoequipo)
        {
        _repoequipo = repoequipo;
        }

        public void OnGet()
        {
            equipos = _repoequipo.GetAllEquipos();
        }
    }
}
