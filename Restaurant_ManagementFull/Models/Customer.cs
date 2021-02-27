using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_ManagementFull.Models
{
  public class Customer
  {
    public int Id { get; set; }

    [ForeignKey(nameof(Gender))]
    public int GenderId { get; set; }
    public Lookup Gender { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => $"{FirstName} {LastName}";}
    public string Mobile { get; set; }
    public string Address { get; set; }

    public ICollection <Invoice> Invoices { get; set; }
  }
}
