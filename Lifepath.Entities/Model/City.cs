
using System.ComponentModel.DataAnnotations;

public class City
{
    [Key]
    public int CityID { get; set; }
    public string Name { get; set; }
}
