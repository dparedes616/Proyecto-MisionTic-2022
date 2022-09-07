using Torneo.App.Dominio;
 namespace Torneo.App.Persistencia
 {
    public interface IRepositorioEquipo
    {
        public Equipo AddEquipo (Equipo equipo, int IdMunicipio, int IdDT );
    }
 }