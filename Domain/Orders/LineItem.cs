using Domain.Products;

namespace Domain.Orders;

public class LineItem
{
    internal LineItem(Guid id, OrderId orderid, ProductId productId, Money price)
    {
        Id = id;
        OrderId = orderid;
        ProductId = productId;
        Price = price;        
    }

    public Guid Id { get; private set;}
    public OrderId OrderId { get; private set; }
    public ProductId ProductId { get; private set; }

    public Money Price { get; private set; }
}