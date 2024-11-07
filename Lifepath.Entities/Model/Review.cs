
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class Review
{
    [Key]
    public int ReviewID { get; set; }
    public string DoctorID { get; set; }
    public string PatientID { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime Date { get; set; }
    public string ReviewStatus { get; set; }

    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
}
