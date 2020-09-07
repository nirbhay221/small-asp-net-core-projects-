using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.Models
{
    public class ViewModel
    {
       public Project project { get; set; }
        public Sales sales { get; set; }
        public ProductSales ProductSales { get; set; }
        public RentedForProject RentedForProject { get; set; }
    }
}
