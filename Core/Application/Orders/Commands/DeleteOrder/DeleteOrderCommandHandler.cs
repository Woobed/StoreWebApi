using Application.Common.Exceprions;
using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IApplicationDbContext _dbContext;
        public DeleteOrderCommandHandler(IApplicationDbContext dbContext)
            => _dbContext = dbContext;

        public async Task Handle(DeleteOrderCommand command, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.orders.FindAsync(command.Id
            , cancellationToken);

            if (entity == null || entity.UserId!= command.UserId)
            {
                throw new NotFoundException(nameof(Order), command.Id);
            }

            _dbContext.orders.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

        }
    }
}
