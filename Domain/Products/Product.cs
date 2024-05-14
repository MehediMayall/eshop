namespace Domain.Products;

public class Product
{
    public ProductId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    public Money Price { get; private set; }

    public SKU Sku{ get; private set; }
}
