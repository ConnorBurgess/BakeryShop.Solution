using System;
using System.Collections.Generic;

namespace BakeryShop.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public bool Description { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}