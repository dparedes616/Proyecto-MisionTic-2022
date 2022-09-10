using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly DataContext _dataContext = new DataContext();
        public Jugador AddJugador(Jugador jugador,string numero, int idequipo, int idposicion)
        {
            var equipoEncontrado =_dataContext.Equipos.Find(idequipo);
            var posicionEncontrada = _dataContext.Posiciones.Find(idposicion);
            jugador.Equipo = equipoEncontrado;
            jugador.Posicion = posicionEncontrada;
            jugador.Numero = numero;
            var jugadorInsertado = _dataContext.Jugadores.Add(jugador);
            _dataContext.SaveChanges();
            return jugadorInsertado.Entity;
        }
    }
}