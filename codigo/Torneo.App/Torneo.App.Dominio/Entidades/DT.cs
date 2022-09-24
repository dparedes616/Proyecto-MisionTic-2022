using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio 
{
    public class DT
    {
        public int Id {get; set;}
        [Display(Name = "Nombre Director Tecnico")]
        public string Nombre { get; set;}
        [Display(Name = "Documento de Indetificación")]
        public string Documento { get; set;}
        [Display(Name = "Telefono de Contacto")]
        public string Telefono { get; set;}
    }
}