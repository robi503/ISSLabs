using LibraryApp.Data;
using LibraryApp.Model;

namespace LibraryApp.Repositories
{
    public class CustomerRepository(LibraryContext context)
    {
        private readonly LibraryContext context = context;

        public IEnumerable<Customer> GetAll()
        {
            return [.. context.Customers];
        }

        public Customer? Get(string username)
        {
            return context.Customers.Find(username);
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Delete(string username)
        {
            var customer = context.Customers.Find(username);
            if (customer != null)
            {
                context.Remove(customer);
                context.SaveChanges(); 
            }
        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}
