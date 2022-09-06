namespace Torneo.App.Dominio 
{
    public class Jugador 
    {
        public int id { get; set;}
        public string Nombre { get; set;}
        public int numero {get; set;}
        public Equipo Equipo {get; set;}
        public Posicion Posicion { get; set;}
    }
}