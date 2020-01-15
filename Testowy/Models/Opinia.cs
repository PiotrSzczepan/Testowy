using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Testowy.Models
{
    public class Opinia
    {
        [BindNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [StringLength(100, ErrorMessage = "Nazwa użytkownika jest za długa")]
        public string NazwaUżytkownika { get; set; }
        [Required(ErrorMessage = "Adres email jest wymagany")]
        [StringLength(100, ErrorMessage = "Adres email jest za długi")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wiadomość jest wymagana")]
        [StringLength(5000, ErrorMessage = "Wiadomość jest za długa")]
        public string Wiadomosc { get; set; }
        public bool OczekujeOdpowiedzi { get; set; }
    }
}
