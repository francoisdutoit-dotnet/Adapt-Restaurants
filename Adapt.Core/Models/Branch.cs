using System;
using System.Collections.Generic;
using System.Text;

namespace Adapt.Core.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public ICollection<RestaurantTime> RestaurantTime { get; set; }

        //ForeignKey
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
