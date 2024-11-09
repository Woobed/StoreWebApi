using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfiguration
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(order =>  order.Id);
            builder.HasIndex(order =>  order.Id).IsUnique();
            builder.Property(order => order.UserId).IsRequired();
            builder.Property(order => order.Note).HasMaxLength(256);
        }
    }
}
