namespace Persistance.EnitityConfigurations;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure (EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(c=> c.Id);
        builder.Property(c=> c.Id).HasConversion(
            productId => productId.Value,
            value => new ProductId(value)
        );

        builder.Property(c=> c.Sku).HasConversion(
            sku => sku.Value,
            value => SKU.Create(value)
        );

        builder.OwnsOne(p => p.Price, pricebuilder =>{
            pricebuilder.Property(m=> m.Currency).HasMaxLength(3);
        });

    }
}