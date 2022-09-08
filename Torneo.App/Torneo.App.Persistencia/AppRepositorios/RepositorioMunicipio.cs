using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Tornero.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly DataContext _dataContext = new DataContext();
        public Municipio AddMunicipio(Municipio municipio)
        {
            var municipioInsertado = _dataContext.Municipios.Add(municipio);
            _dataContext.SaveChanges();
            return municipioInsertado.Entity;
        }
    }
}