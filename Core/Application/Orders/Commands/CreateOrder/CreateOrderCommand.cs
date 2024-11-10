using MediatR;

namespace Application.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string? Adress {  get; set; }
        public string? Note { get; set; }
    }
}
