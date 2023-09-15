﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }

        public string CompanyName { get; set; } = null!;

        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
