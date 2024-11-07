
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class SignUpLog
{
    [Key]
    public int LogID { get; set; }
    public string UserID { get; set; }
    public DateTime SignupDate { get; set; }
    public string IPAddress { get; set; }

    public AspNetUser User { get; set; }
}
