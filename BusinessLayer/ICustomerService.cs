using DataAccesslayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ICustomerService
    {
        Task<IEnumerable<NewCustomer>> GetCustomersAsync();
        //Task<NewCustomer> GetCustomerByIdAsync(int id);
        Task<NewCustomer> CreateCustomerAsync(NewCustomer newCustomer);
        ////Task<List<Student>> GetStudentList();
        Task UpdateCustomer(NewCustomer newCustomer);
        Task DeleteCustomer(int key);
    }
}
