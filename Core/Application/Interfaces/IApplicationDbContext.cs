using Domain;
using Microsoft.EntityFrameworkCore;


namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Order> orders { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
