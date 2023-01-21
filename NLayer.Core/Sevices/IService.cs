using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Sevices
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        //IQueryable oldugu zaman ToList  ToListAsync gibi ifadelere ihtiyac duyar buda bize ekstra sorgu göndermemize yarar 
        Task<IEnumerable<T>> GetAllAsycn();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        //Asycn kullanmamızın sebebi memoryde uzun süren işlemlerin olması
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<T> AddRangeAsycn(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
