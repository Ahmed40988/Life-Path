using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lifepath.Entities.Model;

public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string DoctorId { get; set; }
    public string? DoctorName { get; set; }
    public string UserID { get; set; }
    public string AvailableDays { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActive { get; set; }
    public string Adress {  get; set; }
    public int Price { get; set; }
    public string ImgUrl { get; set; }
    public string Bio {  get; set; }
    public int Rating { get; set; }
    public AspNetUser User { get; set; }
    public int SpecializationID { get; set; }
    public Specialization Specialization { get; set; }




}
