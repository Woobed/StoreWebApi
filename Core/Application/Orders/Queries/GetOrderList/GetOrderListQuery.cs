using MediatR;

namespace Application.Orders.Queries.GetOrderList
{
    public class GetOrderListQuery : IRequest<OrderListViewModel>
    {
        public Guid UserId { get; set; }
    }
}
