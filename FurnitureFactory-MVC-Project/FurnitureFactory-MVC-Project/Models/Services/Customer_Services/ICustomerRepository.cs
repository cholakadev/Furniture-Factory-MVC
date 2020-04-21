namespace FurnitureFactory_MVC_Project.Models.Services.Customer_Services
{
    using System.Collections.Generic;

    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomer(int id);

        Customer Update(Customer updatedCustomer);

        Customer Add(Customer newCustomer);

        Customer Delete(int id);
    }
}
