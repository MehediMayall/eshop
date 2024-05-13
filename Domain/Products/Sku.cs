namespace Domain.Products;

// Stock Keeping Unit
public record Sku
{
    private const int DefaultLenght = 15;
    private Sku(string Value) => this.Value = Value;
    public string Value { get; private set; }
    public static Sku? Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return null;

        if (value.Length != DefaultLenght) return null;

        return new Sku(value);
    }
}