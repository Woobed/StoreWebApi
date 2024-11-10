using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IApplicationDbContext _dbContext;

        public CreateOrderCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateOrderCommand request,
            CancellationToken cancellationToken)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Note = request.Note,
                Price = request.Price,
                Created = DateTime.UtcNow.ToString("dd-MM-yyyy HH.mm.ss"),
                Adress = request.Adress
            };

            await _dbContext.orders.AddAsync(order);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return order.Id;
        }
    }
}
