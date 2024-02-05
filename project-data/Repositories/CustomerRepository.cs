using project_data.Context;
using project_data.Entities;

namespace project_data.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }


}
