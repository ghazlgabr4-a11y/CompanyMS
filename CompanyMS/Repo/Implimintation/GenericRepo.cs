using CompanyMS.DB;
using CompanyMS.Repo.Interface;
using Microsoft.EntityFrameworkCore;

namespace CompanyMS.Repo.Implimintation
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> db;
        public GenericRepo(AppDbContext context)
        {
            _context = context;
            db= _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
             await db.AddAsync(entity);
        }

        public  void Delete(T entity)
        {
             db.Remove(entity);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await db.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await db.FindAsync(id);
        }

        public void Update(T entity)
        {
          db.Remove(entity);
        }
    }
}
