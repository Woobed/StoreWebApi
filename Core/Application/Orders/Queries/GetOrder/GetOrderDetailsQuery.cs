using Application.Orders.Queries.GetOrderList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Queries.GetOrder
{
    public class GetOrderDetailsQuery:IRequest<OrderDetailsViewModel>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
       /* public  string? Adress {  get; set; }
        public string? Creation {  get; set; }
        public string? Note { get; set; }

        public decimal Price { get; set; }*/
    }
}
