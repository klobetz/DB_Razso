using System.ComponentModel.DataAnnotations;

namespace BlazorApp_DB_Entity.Modell
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="A mező kitöltése kötelező")]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező")]
        [MaxLength(60)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező")]
        [MinLength(8,ErrorMessage = "a jelszónak legalább 8 karakternek kell tartalmaznia")]
        [MaxLength(20,ErrorMessage = "a jelszó maximum 20 karakter hosszú lehet")]
        [DataType(DataType.Password)]        
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", ErrorMessage ="A jeszónak: kisbetűt, nagybetűt és számot valamint speciális karaktert kell tartalmaznia")]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BirsthDay { get; set; } = new DateTime(2010,01,01);

    }
}
