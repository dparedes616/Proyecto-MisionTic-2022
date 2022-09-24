using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Posicion 
    {
        public int Id {get; set;}
        [Display(Name = "Nombre posición")]
        public string Nombre { get; set;}
    }
}