using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Domain.Models
{
    public class Order : DomainModelBase
    {
        public string Number { get; set; }
        public OrderDetails Details { get; set; }
    }
}
