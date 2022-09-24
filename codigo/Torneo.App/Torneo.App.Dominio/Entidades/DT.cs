using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio 
{
    public class DT
    {
        public int Id {get; set;}
        [Display(Name = "Nombre Director Tecnico")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set;}
        [Display(Name = "Documento de Indetificación")]
        [Required(ErrorMessage = "El documento es obligatorio")]
        public string Documento { get; set;}
        [Display(Name = "Telefono de Contacto")]
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set;}
    }
}