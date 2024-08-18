using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCAssignment2.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is must")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "Only alphabets are allowed")]
        [MinLength(10, ErrorMessage = "Min 10 characters needed")]
        [MaxLength(30, ErrorMessage = "Max 30 characters allowed")]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Doj { get; set; }
        
        [Required]
        public string Dept { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [NotMapped]
        [DataType(DataType.Password)]
        public string ReTypePassword { get; set; }

    }
}
