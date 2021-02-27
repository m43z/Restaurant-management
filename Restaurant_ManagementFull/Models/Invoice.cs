using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_ManagementFull.Models
{
  public class Invoice
  {
    public int Id { get; set; }
    public DateTime Date { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; } 
    public Customer Customer { get; set; }

    public ICollection<InvoiceDetails> InvoiceDetailses { get; set; }
  }
}
