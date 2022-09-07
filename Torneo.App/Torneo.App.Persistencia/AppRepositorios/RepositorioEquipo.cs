using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Tornero.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly DataContext _dataContext = new DataContext();
        public Equipo AddEquipo(Equipo equipo)
        {
            var equipoInsertado = _dataContext.Equipos.Add(equipo);
            _dataContext.SaveChanges();
            return equipoInsertado.Entity;
        }
    }
}