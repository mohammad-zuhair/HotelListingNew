using System.Linq.Expressions;

namespace HotelListingNew.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
             );

        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);

        Task Insert(T entity);

        Task InsertRang(IEnumerable<T> entities);

        Task Delete(int id);

        void DeleteRang(IEnumerable<T> entities);

        void Update(T entity);
    }
}
