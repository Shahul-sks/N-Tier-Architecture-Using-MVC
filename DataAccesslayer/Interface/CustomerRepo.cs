using DataAccesslayer.Data;
using DataAccesslayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Interface
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerContext customerContext;

        public CustomerRepo(CustomerContext customerContext )
        {
            this.customerContext = customerContext;
        }

        public async Task<IEnumerable<NewCustomer>> GetCustomersAsync()
        {
            return await customerContext.newCustomers.ToListAsync();
        }

        public async Task<NewCustomer> CreateCustomerAsync(NewCustomer newCustomer)
        {
            customerContext.newCustomers.Add(newCustomer);
            await customerContext.SaveChangesAsync();
            return newCustomer;
        }

        public async Task UpdateCustomer(NewCustomer updatedCustomer)
        {
            customerContext.newCustomers.Update(updatedCustomer);
            await customerContext.SaveChangesAsync();
        }

        public async Task DeleteCustomer(int customerId)
        {
            var customerToDelete = await customerContext.newCustomers.FindAsync(customerId);
            if (customerToDelete != null)
            {
                customerContext.newCustomers.Remove(customerToDelete);
                await customerContext.SaveChangesAsync();
            }
        }

    }
}
