using Domain.Products;

namespace Domain.Orders;

public class LineItem
{
    // private LineItem(LineItemId id, OrderId orderid, ProductId productId, Money price)
    // {
    //     this.Id = id;
    //     this.OrderId = orderid;
    //     this.ProductId = productId;
    //     this.Price = price;        
    // }

    private LineItem(){}

    public LineItemId Id { get; private set;}
    public OrderId OrderId { get; private set; }
    public ProductId ProductId { get; private set; }

    public Money Price { get; private set; }

    public static LineItem Create(LineItemId id, OrderId orderid, ProductId productId, Money price)
    {
        var lineItem = new LineItem()
        {
            Id = id,
            OrderId = orderid,
            ProductId = productId,
            Price = price,
        };
        return  lineItem;       
    }

}
