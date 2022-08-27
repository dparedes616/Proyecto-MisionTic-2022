namespace Torneo.App.Dominio
{
    public class Equipos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Municpios Municpios {get; set;}
        public DT DirectorTecnico { get; set;}
        
    }
}