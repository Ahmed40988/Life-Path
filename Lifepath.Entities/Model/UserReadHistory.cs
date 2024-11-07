
using System.ComponentModel.DataAnnotations;

public class UserReadHistory
{
    [Key]
    public int HistoryID { get; set; }
    public string PatientID { get; set; }
    public int PostID { get; set; }
    public DateTime ReadDate { get; set; }

    public Patient Patient { get; set; }
    public BlogPost Post { get; set; }
}
