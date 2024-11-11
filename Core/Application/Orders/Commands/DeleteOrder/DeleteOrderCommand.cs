using MediatR;

namespace Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommand:IRequest
    {
        public Guid Id { get; set; }
    }
}
