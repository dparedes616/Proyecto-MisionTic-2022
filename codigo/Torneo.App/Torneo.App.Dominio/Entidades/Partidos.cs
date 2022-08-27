namespace Torneo.App.Dominio
{
    public class Partidos 
    {
        public int Id { get; set;}
        public DateTime FechaHora {get; set;}
        public Equipos Local { get; set;}
        public int MarcadorLocal { get; set;}
        public Equipos Visitante {get; set;}
        public int MarcadorVisitante {get; set;}

    }
}