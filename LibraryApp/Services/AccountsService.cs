using LibraryApp.Model;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class AccountsService(CustomerRepository customerRepository, LibrarianRepository librarianRepository)
    {
        private readonly CustomerRepository customerRepository = customerRepository;

        private readonly LibrarianRepository librarianRepository = librarianRepository;

        public Librarian? GetLibrarian(string username)
        {
            return librarianRepository.FindByUsername(username);
        }

        public void RegisterLibrarian(Librarian librarian)
        {
            librarianRepository.Add(librarian);
        }

        public void AddCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public Customer? GetCustomer(string username)
        {
            return customerRepository.Get(username);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }

        public void UpdateCustomer(Customer customer)
        {
            customerRepository.Update(customer);
        }

        public void DeleteCustomer(string username)
        {
            customerRepository.Delete(username);
        }
    }
}
