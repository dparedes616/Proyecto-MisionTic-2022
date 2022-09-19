namespace Torneo.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Municipio Municipio {get; set;}
        public DT DirectorTecnico { get; set;}
        
    }
}