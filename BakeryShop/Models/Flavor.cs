using System.Collections.Generic;

namespace BakeryShop.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}