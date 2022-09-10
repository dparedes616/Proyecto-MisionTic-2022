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
    }
}