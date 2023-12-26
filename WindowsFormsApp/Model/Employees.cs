using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp.Model
{
  public class Employees
  {
    public int Id { get; set; }

    [Required, StringLength(70, MinimumLength = 5)]
    public string Name { get; set; }

    [Required, EmailAddress, StringLength(70, MinimumLength = 5)]
    public string Email { get; set; }

    [Required]
    public decimal Salary { get; set; }

    [Required]
    public string Sex { get; set; }

    [Required]
    public string TypeOfContract { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime UpdateDate { get; set;}
  }
}
