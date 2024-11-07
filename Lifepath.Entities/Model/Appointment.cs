
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class Appointment
{
    [Key]
    public int AppointmentID { get; set; }
    public string PatientID { get; set; }
    public string DoctorID { get; set; }
    public int CityID { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; }
    public string PaymentStatus { get; set; }

    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
    public City City { get; set; }
}
