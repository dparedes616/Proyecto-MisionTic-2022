using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioDT : IRepositorioDT
    {
        private readonly DataContext _dataContext = new DataContext();

        public  DT AddMunicipio(DT dT)
        {
            var dTInsertado = _dataContext.DirectoresTecnicos.Add(dT);
            _dataContext.SaveChanges();
            return dTInsertado.Entity;
        }
    }
}