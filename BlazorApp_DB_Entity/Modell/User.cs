using System.ComponentModel.DataAnnotations;

namespace BlazorApp_DB_Entity.Modell
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", ErrorMessage ="a jelszónak legalább 8 karakternek kell lennie!")]
        public string? Password { get; set; }

    }
}
