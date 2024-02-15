using DataAccesslayer.Data;
using DataAccesslayer.Interface;
using DataAccesslayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService( ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public async Task<IEnumerable<NewCustomer>> GetCustomersAsync()
        {
            return await _customerRepo.GetCustomersAsync();
        }

        public async Task UpdateCustomer(NewCustomer newCustomer)
        {
            await _customerRepo.UpdateCustomer(newCustomer);
        }

        public async Task DeleteCustomer(int customerId)
        {
            await _customerRepo.DeleteCustomer(customerId);
        }

        public async Task<NewCustomer> CreateCustomerAsync(NewCustomer newCustomer)
        {
            return await _customerRepo.CreateCustomerAsync(newCustomer);
        }
    }
}
