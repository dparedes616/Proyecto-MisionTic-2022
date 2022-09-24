using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio 
{
    public class Jugador 
    {
        public int id { get; set;}
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set;}
        [Required(ErrorMessage = "El numero es obligatorio")]
        public int Numero {get; set;}
        public Equipo Equipo {get; set;}
        public Posicion Posicion { get; set;}
    }
}