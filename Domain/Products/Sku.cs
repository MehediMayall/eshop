namespace Domain.Products;

// Stock Keeping Unit
public record SKU
{
    private const int DefaultLenght = 15;
    private SKU(string Value) => this.Value = Value;
    public string Value { get; private set; }
    public static SKU? Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return null;

        if (value.Length != DefaultLenght) return null;

        return new SKU(value);
    }
}