using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Partidos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipo;

        public Partido partido {get; set;}
        public IEnumerable<Equipo> equipo { get; set; }
        
        public CreateModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipo)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
        }

        public void OnGet()
        {
            partido = new Partido();
            equipo = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(Partido partido, DateTime FechaHora, int IdLocal, int marcadorLocal, int IdVisitante, int marcadorVisitante)
        {
            Console.WriteLine("Error" + IdLocal);
            partido = new Partido();
            equipo = _repoEquipo.GetAllEquipos();
            _repoPartido.AddPartido(partido, FechaHora, IdLocal, marcadorLocal, IdVisitante, marcadorVisitante);
            return RedirectToPage("Index");
        }
    }
}
