namespace Persistance.EnitityConfigurations;

public class OrderConfiguration: IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(c=> c.Id);

        builder.Property(c=> c.Id).HasConversion(
            order => order.Value,
            value => new OrderId(value)
        );


        builder.HasOne<Customer>()
            .WithMany()
            .HasForeignKey(k => k.CustomerId)
            .IsRequired();

        builder.HasMany(c => c.LineItems)
            .WithOne()
            .HasForeignKey(x=> x.OrderId);
            
    }
}