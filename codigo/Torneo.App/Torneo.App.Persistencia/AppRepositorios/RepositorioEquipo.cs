using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly DataContext _dataContext = new DataContext();

        public Equipo AddEquipo(Equipo equipo, int IdMunicipio, int IdDT)
        {
            var municipioEncontrado = _dataContext.Municipios.Find(IdMunicipio);
            var DTEncontrado = _dataContext.DirectoresTecnicos.Find(IdDT);
            equipo.Municipio = municipioEncontrado;
            equipo.DirectorTecnico = DTEncontrado;
            var equipoInsertado = _dataContext.Equipos.Add(equipo);
            _dataContext.SaveChanges();
            return equipoInsertado.Entity;
        }
    }
}