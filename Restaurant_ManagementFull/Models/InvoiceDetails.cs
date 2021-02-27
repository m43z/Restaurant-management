using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_ManagementFull.Models
{
  public class InvoiceDetails
  {
    public int Id { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get=>Price*Count; }

    public int FoodsId { get; set; }
    public Food Food { get; set; }

    public int InvoiceId { get; set; }
    public Invoice Invoice { get; set; }
  }
}
