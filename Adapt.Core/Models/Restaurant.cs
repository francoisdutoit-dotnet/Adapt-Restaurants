using System;
using System.Collections.Generic;
using System.Text;

namespace Adapt.Core.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string LogoName { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
