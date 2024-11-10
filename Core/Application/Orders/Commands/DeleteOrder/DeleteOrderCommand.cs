﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommand:IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
