using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugador
    {
        public Jugador AddJugador(Jugador jugador,string numero, int idequipo, int idposcion);
        public IEnumerable<Jugador> GetAllJugadores();
    }
}