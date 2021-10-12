using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ToDoTask.Domain.Interfaces
{
    public interface IGenericRespository<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        /*Task<List<T>> GetByProperty(Expression<Func<T, bool>> where = null,Func<IQueryable<T> , IOrderedQueryable<T>> orderBy = null,int pageNumber = 1, int pageSize=10);*/
        Task<Boolean> Add(T entity);
        Task<Boolean> Update(T entity);
        Task<Boolean> Delete(int id);
    }
}