using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Adapt.Core.ViewModels
{
    public class RestaurantViewModel
    {
        [DisplayName("RestaurantId")]
        public int RestaurantId { get; set; }
        [DisplayName("Name")]
        public string RestaurantName { get; set; }
        [DisplayName("Logo")]
        public string RestaurantLogoName { get; set; }
        [DisplayName("BranchId")]
        public int BranchId { get; set; }
        [DisplayName("Branch Name")]
        public string BranchName { get; set; }
        [DisplayName("Street")]
        public string BranchStreetName { get; set; }
        [DisplayName("Number")]
        public string BranchStreetNumber { get; set; }
        [DisplayName("Suburb")]
        public string BranchSuburb { get; set; }
        [DisplayName("Postal Code")]
        public string BranchPostalCode { get; set; }
        [DisplayName("Open")]
        public string OpeningTime { get; set; }
        [DisplayName("Close")]
        public string ClosingTime { get; set; }
    }
}
