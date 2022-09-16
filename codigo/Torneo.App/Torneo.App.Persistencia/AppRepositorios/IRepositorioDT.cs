using Torneo.App.Dominio;
 namespace Torneo.App.Persistencia
 {
    public interface IRepositorioDT
    {
        public DT AddDT (DT dT );
        public IEnumerable<DT> GetAlldT();
        public  DT GetDT(int idDT);
    }
 }