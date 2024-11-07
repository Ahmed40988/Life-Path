
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class Notification
{
    [Key]
    public int NotificationID { get; set; }
    public string UserID { get; set; }
    public string Message { get; set; }
    public DateTime Date { get; set; }
    public string NotificationType { get; set; }
    public string Status { get; set; }

    public AspNetUser User { get; set; }
}
