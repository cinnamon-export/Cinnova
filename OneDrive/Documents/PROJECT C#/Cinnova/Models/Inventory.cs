using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinnova.Models
{
  
   
        public class Inventory
        {
            public int ItemId { get; set; }

            public string Category { get; set; }

            public int Quantity { get; set; }

            public string Unit { get; set; }

            public DateTime LastUpdated { get; set; }

            public int MinStock { get; set; }

            public string Status { get; set; }
        }
   
}

