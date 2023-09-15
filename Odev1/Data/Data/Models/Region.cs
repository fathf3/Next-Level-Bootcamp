using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public partial class Region
    {
        public int RegionId { get; set; }

        public string RegionDescription { get; set; } = null!;

        public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
    }
}
