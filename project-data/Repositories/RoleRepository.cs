using project_data.Context;
using project_data.Entities;

namespace project_data.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }


}
