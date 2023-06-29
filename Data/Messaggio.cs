using System.ComponentModel.DataAnnotations;
namespace Blazoteca.Data
{
    public class Messaggio
    {
        [Required(ErrorMessage = "Inserire il proprio nome e cognome")]
        [StringLength(50,MinimumLength = 2, ErrorMessage = "Non può essere minore di 2 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Inserire un'email valida")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inserire l'oggetto del messaggio")]
        public string Oggetto { get; set; }

        [Required(ErrorMessage = "Inserire il testo del messaggio")]
        public string TestoMessaggio { get; set; }
    }
}

