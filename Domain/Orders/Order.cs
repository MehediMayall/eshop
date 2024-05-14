using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

public class Order
{
    private Order() {}
    private readonly HashSet<LineItem> lineItems = new();
    public OrderId  Id { get; private set; }

    public CustomerId CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order()
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customer.Id,
        };

        return order;
    }

    public void Add(Product product)
    {
        var lineItem = new LineItem(
            Guid.NewGuid(),
            Id,
            product.Id,
            product.Price
        );
        lineItems.Add(lineItem);   
    }

}
