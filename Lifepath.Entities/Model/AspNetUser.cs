using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifepath.Entities.Model;
public class AspNetUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string UserID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastLogin { get; set; }
    public int CityID { get; set; }
    public string PhoneNumber { get; set; }

    public City City { get; set; }

    public ICollection<AspNetUserRole> UserRoles { get; set; } = new List<AspNetUserRole>();

}
