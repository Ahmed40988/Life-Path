
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class ChatMessage
{
    [Key]
    public int MessageID { get; set; }
    public string SenderID { get; set; }
    public string ReceiverID { get; set; }
    public string MessageText { get; set; }
    public DateTime Timestamp { get; set; }
    public int SessionID { get; set; }
    public string Status { get; set; }

    public AspNetUser Sender { get; set; }
    public AspNetUser Receiver { get; set; }
}
