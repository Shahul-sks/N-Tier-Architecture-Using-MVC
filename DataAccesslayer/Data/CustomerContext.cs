using DataAccesslayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<NewCustomer> newCustomers { get; set; }

    }
}
