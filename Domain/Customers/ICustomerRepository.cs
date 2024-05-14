namespace Domain.Customers;

public interface  ICustomersService
{
    Task<Customer?> GetByIdAsync(CustomerId id);
}