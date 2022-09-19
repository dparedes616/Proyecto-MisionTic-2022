using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly DataContext _dataContext = new DataContext();

        public Jugador AddJugador (Jugador jugador, int IdEquipo, int IdPosicion)
        {
            var equipoEncontrado = _dataContext.Equipos.Find(IdEquipo);
            var posicionEncontrada = _dataContext.Posiciones.Find(IdPosicion);
            jugador.Equipo = equipoEncontrado;            
            jugador.Posicion = posicionEncontrada;
            var jugadorInsertado = _dataContext.Jugadores.Add(jugador);
            _dataContext.SaveChanges();
            return jugadorInsertado.Entity;
        }

        public IEnumerable<Jugador> GetAllJugadores()
        {
            var jugador = _dataContext.Jugadores
            .Include(e => e.Equipo)
            .Include(e => e.Posicion)
            .ToList();
            return jugador;
        }

        public Jugador GetJugador(int idJugador)
        {
            var jugadorEncontrado = _dataContext.Jugadores
                .Where(e => e.id == idJugador)
                .Include(e => e.Equipo)
                .Include(e => e.Posicion)
                .FirstOrDefault();
            return jugadorEncontrado;
        }
    }
}