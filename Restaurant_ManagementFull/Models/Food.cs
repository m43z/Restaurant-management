using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_ManagementFull.Models
{
  public class Food
  {
    public int Id{ get; set; }

    public int TypeFoodId { get; set; }
    public Lookup TypeFood { get; set; }
    public bool IsAvailable { get; set; } = true;
    public string Title { get; set; }
    public string Decreption { get; set; }
    public Decimal Price { get; set; }

  }
}
