namespace Torneo.App.Dominio
{
    public class Equipos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Municipios Municipios {get; set;}
        public DT DirectorTecnico { get; set;}
        
    }
}