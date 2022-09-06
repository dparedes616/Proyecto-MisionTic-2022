namespace Torneo.App.Dominio
{
    public class Partido
    {
        public int Id { get; set;}
        public DateTime FechaHora {get; set;}
        public int Local { get; set;}
        public int MarcadorLocal { get; set;}
        public int Visitante {get; set;}
        public int MarcadorVisitante {get; set;}

    }
}