using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataTransferObject;

public class DepartmentRequest
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    [Required]
    public string Code { get; set; } = null!;
    public DateTime CreatedOn {  get; set; }
}
