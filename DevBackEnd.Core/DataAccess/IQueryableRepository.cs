using DevBackEnd.Core.Entities;
using System.Linq;

namespace DevBackEnd.Core.DataAccess
{
    public interface IQueryableRepository<T>where T:class,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}