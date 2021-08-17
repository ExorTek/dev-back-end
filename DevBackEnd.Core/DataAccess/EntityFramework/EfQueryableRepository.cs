using DevBackEnd.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevBackEnd.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private DbSet<T> _entities;

        EfQueryableRepository(DbContext context, DbSet<T> entities)
        {
            _context = context;
            _entities = entities;
        }

        public IQueryable<T> Table => Entities;

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities != null) return _entities;
                _entities = _context.Set<T>();
                return _entities;
            }
        }
    }
}