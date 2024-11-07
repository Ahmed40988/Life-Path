
using System.ComponentModel.DataAnnotations;

public class Specialization
{
    [Key]
    public int SpecializationID { get; set; }
    public string Name { get; set; }
}
