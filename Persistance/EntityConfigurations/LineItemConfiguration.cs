namespace Persistance.EnitityConfigurations;

public class LineItemConfiguration: IEntityTypeConfiguration<LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> builder)
    {
        builder.HasKey(x=> x.Id);

        builder.Property(x=> x.Id).HasConversion(
            lineItemId => lineItemId.Value,
            value => new LineItemId(value)
        );



        builder.HasOne<Product>()
            .WithMany()
            .HasForeignKey(x=> x.ProductId);

        builder.OwnsOne(x => x.Price);
    }
}