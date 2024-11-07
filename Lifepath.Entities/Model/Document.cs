
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class Document
{
    [Key]
    public int DocumentID { get; set; }
    public string PatientID { get; set; }
    public string AssociatedDoctorID { get; set; }
    public int AssociatedPharmacyID { get; set; }
    public string DocumentType { get; set; }
    public string FilePath { get; set; }
    public DateTime UploadDate { get; set; }

    public Patient Patient { get; set; }
    public Doctor AssociatedDoctor { get; set; }
}
