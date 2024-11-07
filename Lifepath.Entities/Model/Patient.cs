
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class Patient
{
    [Key]
    public string PatientID { get; set; }
    public string UserID { get; set; }
    public string Gender { get; set; }
    public DateTime DOB { get; set; }

    public AspNetUser User { get; set; }
}
