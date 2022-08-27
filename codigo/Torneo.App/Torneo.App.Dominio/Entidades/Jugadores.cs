namespace Torneo.App.Dominio 
{
    public class Jugadores 
    {
        public int id { get; set;}
        public string Nombre { get; set;}
        public int numero {get; set;}
        public Equipos Equipos {get; set;}
        public Posiciones Posiciones { get; set;}
    }
}