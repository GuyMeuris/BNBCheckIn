using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Repository.IRepository.IGenericRepository;

namespace Business.Repository
{
    // This generic class inherits from the generic interface that implements
    // some basic 'CRUD'-operations.

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BnBDbContext _context;

        private readonly DbSet<T> _db;

        public GenericRepository(BnBDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        //*****************************************************************************************

        // Here we will provide a body to the function-headers that were implemented 
        // by inheriting from the interface.

        public async Task Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> Get(System.Linq.Expressions.Expression<System.Func<T, bool>> expression,
            string checkSomething = null, string checkSomethingElse = null,
                List<string> includes = null, List<string> includes2 = null, 
                    List<string> includes3 = null, List<string> includes4 = null)
        {
            IQueryable<T> query = _db;

            if (includes is not null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (includes2 is not null)
            {
                foreach (var includeProperty in includes2)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (includes3 is not null)
            {
                foreach (var includeProperty in includes3)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (includes4 is not null)
            {
                foreach (var includeProperty in includes4)
                {
                    query = query.Include(includeProperty);
                }
            }

           

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(System.Linq.Expressions.Expression<System.Func<T, bool>> expression = null,
                string checkSomething = null, string checkSomethingElse = null,
                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                        List<string> includes = null, List<string> includes2 = null, 
                            List<string> includes3 = null, List<string> includes4 = null)
        {
            IQueryable<T> query = _db;

            if (expression is not null)
            {
                query = query.Where(expression);
            }
            if (includes is not null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (includes2 is not null)
            {
                foreach (var includeProperty in includes2)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (includes3 is not null)
            {
                foreach (var includeProperty in includes3)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (includes4 is not null)
            {
                foreach (var includeProperty in includes4)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (orderBy is not null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Create(T entity)
        {
            await _db.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
