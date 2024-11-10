using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Queries.GetOrderList
{
    public class OrderListViewModel
    {
        public IList<OrderViewModel>? Orders { get; set; }

    }
}
