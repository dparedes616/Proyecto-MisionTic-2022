using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Partido
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El horario es obligatorio")]
        public DateTime FechaHora {get; set;}
        public Equipo Local { get; set;}
        public int MarcadorLocal { get; set;}
        public Equipo Visitante {get; set;}
        public int MarcadorVisitante {get; set;}

    }
}