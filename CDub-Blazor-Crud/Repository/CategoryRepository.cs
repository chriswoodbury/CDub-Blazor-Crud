using CDub_Blazor_Crud.Models;
using CDub_Blazor_Crud.Data;
using Microsoft.EntityFrameworkCore;

namespace CDub_Blazor_Crud.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
    
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Category> Create(Category obj)
        {
            obj.CreatedDateTime = DateTime.Now;

            var addedObj = _db.Categories.Add(obj);
            await _db.SaveChangesAsync();

            return obj;
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);

            if (obj != null)
            {
                _db.Categories.Remove(obj);
                return await _db.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<Category> Get(int id)
        {
            var obj = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);

            if (obj != null)
            {
                return obj;
            }

            return new Category();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return _db.Categories.OrderBy(cat => cat.DisplayOrder);
        }

        public async Task<Category> Update(Category obj)
        {
            var objFromDb = await _db.Categories.FirstOrDefaultAsync(c => c.Id == obj.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.DisplayOrder = obj.DisplayOrder;
                _db.Categories.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }

            return obj;
        }
    }
}

