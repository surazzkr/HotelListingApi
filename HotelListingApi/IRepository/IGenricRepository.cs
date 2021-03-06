using HotelListingApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace HotelListingApi.IRepository
{
    public interface IGenricRepository<T> where T: class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderby = null,
            List<string> includes = null
            );

        /* http://localhost:7133/api/Country/?pagesize=10&pagenumber=1 */
        Task<IPagedList<T>> GetPagedList(RequestParams requestParams, List<string> includes = null);
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
