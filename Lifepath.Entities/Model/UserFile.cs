
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class UserFile
{
    [Key]
    public int FileID { get; set; }
    public string UserID { get; set; }
    public string AssociatedDoctorID { get; set; }
    public int AssociatedPharmacyID { get; set; }
    public string FilePath { get; set; }
    public string FileType { get; set; }
    public DateTime UploadDate { get; set; }

    public AspNetUser User { get; set; }
    public Doctor AssociatedDoctor { get; set; }
}
