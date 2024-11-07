
using Lifepath.Entities.Model;
using System.ComponentModel.DataAnnotations;

public class BlogPost
{
    [Key]
    public int PostID { get; set; }
    public string DoctorID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public string Category { get; set; }
    public string Tags { get; set; }
    public int ViewCount { get; set; }

    public Doctor Doctor { get; set; }
}
