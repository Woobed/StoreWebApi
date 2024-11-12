using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.EntityConfiguration;

namespace Persistance
{
    public class ApplicationDbContext :DbContext, IApplicationDbContext
    {
        public DbSet<Order> orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OrderConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
