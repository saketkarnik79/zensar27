using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Person
{
    [Display(Name="Person Id")]
    [Key]
    public int Id { get; set; }

    [Display(Name="Person Name")]
    [Required(ErrorMessage ="Name is mandatory.")]
    [StringLength(50, MinimumLength = 3)]
    //[MaxLength(50)]
    [RegularExpression("^[a-zA-Z .]+$", ErrorMessage = "Name contains some invalid characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Age is mandatory.")]
    [Display(Name="Person Age")]
    [Range(18, 60)]
    public int Age { get; set; }
}