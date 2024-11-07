
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class LoginLog
{
    [Key]
    public int LogID { get; set; }
    public string UserID { get; set; }
    public DateTime LoginDate { get; set; }
    public string IPAddress { get; set; }
    public string DeviceInfo { get; set; }

    public AspNetUser User { get; set; }
}
