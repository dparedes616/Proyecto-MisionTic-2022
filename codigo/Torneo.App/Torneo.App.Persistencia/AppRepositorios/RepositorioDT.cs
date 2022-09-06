using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioDT : IRepositorioDT
    {
        private readonly DataContext _dataContext = new DataContext();

        public  DT AddDT(DT dT)
        {
            var dtInsertado = _dataContext.DirectoresTecnicos.Add(dT);
            _dataContext.SaveChanges();
            return dtInsertado.Entity;
        }
    }
}