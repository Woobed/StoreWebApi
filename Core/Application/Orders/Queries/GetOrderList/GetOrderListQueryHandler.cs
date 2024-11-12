using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Orders.Commands;

namespace Application.Orders.Queries.GetOrderList
{
    public class GetOrderListQueryHandler: IRequestHandler<GetOrderListQuery, OrderListViewModel>
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderListQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<OrderListViewModel> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            var OrderList = await _dbContext.orders.Where(order=>order.UserId==request.UserId)
                .ProjectTo<OrderViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new OrderListViewModel { Orders = OrderList };
        }
    }
}
