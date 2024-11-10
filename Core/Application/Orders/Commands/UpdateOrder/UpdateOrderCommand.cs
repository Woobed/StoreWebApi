using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand :IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Note {  get; set; }

        public decimal Price { get; set; }

        public string? Adress { get; set; }

    }
}
