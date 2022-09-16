using CDub_Blazor_Crud.Models;

namespace CDub_Blazor_Crud.Repository
{
    public interface ICategoryRepository
    {
            public Task<Category> Create(Category obj);
            public Task<Category> Update(Category obj);
            public Task<int> Delete(int id);
            public Task<Category> Get(int id);
            public Task<IEnumerable<Category>> GetAll();
        }
    }

