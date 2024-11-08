using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace DTO;

public class DoctorDto
{
    public String DoctorName { get; set; }
    public string ImgUrl { get; set; }
    public string Bio { get; set; }
    public string Email { get; set; }
    public string AvailableDays { get; set; }
    public int Rating { get; set; }
    public float Price { get; set; }
    public String Address { get; set; }
    public int SpecializationID { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActive { get; set; }
}
