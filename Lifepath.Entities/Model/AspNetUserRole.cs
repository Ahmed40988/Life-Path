using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lifepath.Entities.Model;

public class AspNetUserRole
{
       [Key]
    public string UserID { get; set; }
    public string RoleID { get; set; }

    public AspNetUser User { get; set; }
    public AspNetRole Role { get; set; }
}
