
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class ChatbotInteraction
{
    [Key]
    public int InteractionID { get; set; }
    public string UserID { get; set; }
    public string QueryText { get; set; }
    public string ResponseText { get; set; }
    public DateTime Timestamp { get; set; }

    public AspNetUser User { get; set; }
}
