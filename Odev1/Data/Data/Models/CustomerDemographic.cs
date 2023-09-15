using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public partial class CustomerDemographic
    {
        public string CustomerTypeId { get; set; } = null!;

        public string? CustomerDesc { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
