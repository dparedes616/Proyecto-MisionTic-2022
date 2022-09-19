using Torneo.App.Dominio;
 namespace Torneo.App.Persistencia
 {
    public interface IRepositorioPartido
    {
        public Partido AddPartido (Partido partido, DateTime FechaHora, int IdLocal, int MarcadorLocal, int IdVisitante, int MarcadorVisitante);
        public IEnumerable<Partido> GetAllPartidos();
        public Partido GetPartido(int idPartido);
    }
 }