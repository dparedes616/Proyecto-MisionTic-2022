using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Tornero.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly DataContext _dataContext = new DataContext();
        public Jugador AddJugador(Jugador jugador)
        {
            var jugadorInsertado = _dataContext.Jugadores.Add(jugador);
            _dataContext.SaveChanges();
            return jugadorInsertado.Entity;
        }
    }
}