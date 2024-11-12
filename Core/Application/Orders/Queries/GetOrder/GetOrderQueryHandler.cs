using Application.Common.Exceprions;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Application.Orders.Queries.GetOrder
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderDetailsQuery, OrderDetailsViewModel>
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<OrderDetailsViewModel> Handle(GetOrderDetailsQuery request,
            CancellationToken cancellationToken)
        {

            var result = await _dbContext.orders.FirstOrDefaultAsync(order => order.Id == request.Id,
                cancellationToken);
            if (result == null || result.UserId != request.UserId) throw new NotFoundException(nameof(Order), request.Id);
            return _mapper.Map<OrderDetailsViewModel>(result);
        }
    }
}
