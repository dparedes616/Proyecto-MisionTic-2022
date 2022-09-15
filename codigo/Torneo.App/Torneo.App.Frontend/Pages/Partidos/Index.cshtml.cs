using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Partidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPartido _repopartido;
        public IEnumerable<Partido> partidos { get; set; }
        public IndexModel(IRepositorioPartido repopartido)
        {
        _repopartido = repopartido;
        }

        public void OnGet()
        {
            partidos = _repopartido.GetAllPartidos();
        }
    }
}
