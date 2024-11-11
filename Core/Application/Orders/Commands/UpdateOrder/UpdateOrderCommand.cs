using MediatR;

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
