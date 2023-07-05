using zKsiekiem.Models;

namespace zKsiekiem.Services
{
    public class CustomerService : ICustomerService
    {
        List <Customer> customers = new List<Customer> {
            new Customer { Id = 1, Name = "Kacper", Surname = "Krok" }, 
            new Customer { Id = 2, Name = "Ksiek", Surname = "Liszka" },
            new Customer { Id = 3, Name = "Basser", Surname = "Koszyk" },
        };                     
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            customers.RemoveAll(customer => customer.Id == id);
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetSingleCustomer(int id)
        {
            var customerToReturn = customers.Find(customer => customer.Id == id);
            
            if(customerToReturn != null)
            {
                return customerToReturn;
            }
            else
            {
                throw new Exception("Nie znaleziono klienta o takim ID!");
            }
        }

        public void UpdateCustomer(Customer customer, int id)
        {
            var customerToUpdate = customers.Find(customer => customer.Id == id);
            customerToUpdate = customer;
        }
    }
}
