using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lifepath.Entities.Model;

public  class AspNetRole
{
    [Key]
    public string RoleID { get; set; }
    public string Name { get; set; }
    public ICollection<AspNetUserRole> UserRoles { get; set; } = new List<AspNetUserRole>();
}
