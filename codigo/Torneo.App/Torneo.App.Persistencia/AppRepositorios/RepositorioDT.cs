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
        public IEnumerable<DT> GetAlldT()
        {
            return _dataContext.DirectoresTecnicos;
        }

        public DT GetDT(int idDT)
        {
            var dtEncontrado = _dataContext.DirectoresTecnicos.Find(idDT);
            return dtEncontrado;
        }

        public DT UpdateDT(DT dT)
        {
            var dTEncontrado = _dataContext.DirectoresTecnicos.Find(dT.Id);
            if (dTEncontrado != null)
            {
                dTEncontrado.Nombre = dT.Nombre;
                dTEncontrado.Documento = dT.Documento;
                dTEncontrado.Telefono = dT.Telefono;
                _dataContext.SaveChanges();
            }
            return dTEncontrado;
        }
    }
}