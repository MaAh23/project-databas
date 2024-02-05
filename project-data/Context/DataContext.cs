using Microsoft.EntityFrameworkCore;
using project_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_data.Context
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet <AddressEntity> Addresses { get; set; }
        public DbSet <CategoryEntity> Categories { get; set; }
        public DbSet <CustomerEntity> Customers { get; set; }
        public DbSet <ProducEntity> Producies { get; set; }
        public DbSet <RoleEntity> Roles { get; set; }


    }
}
