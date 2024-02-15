using DataAccesslayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Interface
{
    public interface ICustomerRepo
    {
        Task<NewCustomer> CreateCustomerAsync(NewCustomer newCustomer);
        Task<IEnumerable<NewCustomer>> GetCustomersAsync();
       // Task<NewCustomer> GetCustomerByIdAsync(int id);

        //Task CreateCustomer(NewCustomer newCustomer);
        ////Task<List<Student>> GetStudentList();
        Task UpdateCustomer(NewCustomer newCustomer);
        Task DeleteCustomer(int key);
    }
}
