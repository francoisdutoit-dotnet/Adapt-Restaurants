using System;
using System.Collections.Generic;
using System.Text;

namespace Adapt.Core.Models
{
    public class RestaurantTime
    {
        public int RestaurantTimeId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }

        //ForeignKey
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
