namespace FurnitureFactory_MVC_Project.Models.Services.Customer_Services
{
    using FurnitureFactory_MVC_Project.Models.DataAccess;
    using System.Collections.Generic;

    public class SQLCustomerRepository : ICustomerRepository
    {
        private readonly FurnitureFactoryDbContext _context;

        public SQLCustomerRepository(FurnitureFactoryDbContext context)
        {
            this._context = context;
        }

        public Customer Add(Customer newCustomer)
        {
            this._context.Customers.Add(newCustomer);
            this._context.SaveChanges();

            return newCustomer;
        }

        public Customer Delete(int id)
        {
            Customer customer = this._context.Customers.Find(id);

            if (customer != null)
            {
                this._context.Customers.Remove(customer);
            }

            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return this._context.Customers;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = this._context.Customers.Find(id);

            return customer;
        }

        public Customer Update(Customer updatedCustomer)
        {
            this._context.Update(updatedCustomer);
            this._context.SaveChanges();

            return updatedCustomer;
        }
    }
}
