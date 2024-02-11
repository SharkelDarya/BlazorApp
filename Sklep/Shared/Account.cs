using System.ComponentModel.DataAnnotations;

namespace Sklep.Shared
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Email jest puste!")]
        [EmailAddress(ErrorMessage = "Email jest nie poprawny!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Pole hasło jest puste!")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Pole drugie hasło jest puste!")]
        [Compare("Password", ErrorMessage = "Hasła są rózne!")]
        public string? ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "Pole miasto jest puste!")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Pole telefon jest puste!")]
        //регулярное выражение "^\d+$", которое соответствует только цифровым символам.
        [RegularExpression(@"^\d+$", ErrorMessage = "Pole telefon może posiadać tylko cyfry!")]
        public string? Telefon { get; set; }

    }
}
