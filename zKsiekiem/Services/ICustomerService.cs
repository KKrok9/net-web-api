using zKsiekiem.Models;

namespace zKsiekiem.Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);
        void UpdateCustomer(Customer customer, int id);

        Customer? GetSingleCustomer(int id);

        List <Customer> GetAllCustomers(); 

    }
}
