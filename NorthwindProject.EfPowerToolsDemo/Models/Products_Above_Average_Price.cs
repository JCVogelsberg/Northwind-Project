using System;
using System.Collections.Generic;

namespace NorthwindProject.EfPowerToolsDemo.Models
{
    public partial class Products_Above_Average_Price
    {
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
