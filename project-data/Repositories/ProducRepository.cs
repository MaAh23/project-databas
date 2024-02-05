using project_data.Context;
using project_data.Entities;

namespace project_data.Repositories
{
    internal class ProducRepository : Repo<ProducEntity>
    {
        public ProducRepository(DataContext context) : base(context)
        {
        }
    }


}
