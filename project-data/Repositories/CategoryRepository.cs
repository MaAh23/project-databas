using project_data.Context;
using project_data.Entities;

namespace project_data.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }


}
