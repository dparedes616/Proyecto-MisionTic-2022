using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext();

        public Partido AddPartido (Partido partido, DateTime FechaHora, int IdLocal, int marcadorLocal, int IdVisitante, int marcadorVisitante)
        {
            var localEcontrado = _dataContext.Equipos.Find(IdLocal);
            var visitanteEcontrado = _dataContext.Equipos.Find(IdVisitante);
            partido.Local = localEcontrado;
            partido.MarcadorLocal = marcadorLocal;
            partido.Visitante = visitanteEcontrado;
            partido.MarcadorVisitante = marcadorVisitante;       
            var partidoInsertado = _dataContext.Partidos.Add(partido);
            _dataContext.SaveChanges();
            return partidoInsertado.Entity;
        }

        public IEnumerable<Partido> GetAllPartidos()
        {
            var partidos = _dataContext.Partidos
            .Include(e => e.Local)
            .Include(e => e.Visitante)
            .ToList();
            return partidos;
        }

        public Partido GetPartido(int idPartido)
        {
            var partidoEncontrado = _dataContext.Partidos
                .Where(e => e.Id == idPartido)
                .Include(e => e.Local)
                .Include(e => e.Visitante)
                .FirstOrDefault();
            return partidoEncontrado;
        }

        public Partido UpdatePartido (Partido partido, DateTime FechaHora, int IdLocal, int marcadorLocal, int IdVisitante, int marcadorVisitante)
        {
            var partidoEncontrado = GetPartido(partido.Id);
            var localEcontrado = _dataContext.Equipos.Find(IdLocal);
            var visitanteEcontrado = _dataContext.Equipos.Find(IdVisitante);
            partidoEncontrado.FechaHora = partido.FechaHora;
            partidoEncontrado.Local = localEcontrado;
            partidoEncontrado.MarcadorLocal = partido.MarcadorLocal;
            partidoEncontrado.Visitante = visitanteEcontrado;
            partidoEncontrado.MarcadorVisitante = partido.MarcadorVisitante;
            _dataContext.SaveChanges();
            return partidoEncontrado;
        }
    }
}