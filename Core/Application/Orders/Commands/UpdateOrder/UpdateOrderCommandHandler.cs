using Application.Common.Exceprions;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandHandler :IRequestHandler<UpdateOrderCommand,Guid>
    {
        private readonly IApplicationDbContext _dbContext;

        public UpdateOrderCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.orders.FirstOrDefaultAsync(order => order.Id == request.Id, cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Order),request.Id);
            }
            entity.UserId = request.UserId;
            entity.Adress= request.Adress;
            entity.Note= request.Note;
            entity.Price= request.Price;


            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
