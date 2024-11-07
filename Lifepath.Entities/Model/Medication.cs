
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class Medication
{
    [Key]
    public int MedicationID { get; set; }
    public string PatientID { get; set; }
    public string DoctorID { get; set; }
    public string MedicationName { get; set; }
    public string Dosage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
}
