using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Data.Repositories.Abstract.Base
{
	public interface IRepository<T> where T : class, new()
	{
		Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

		Task InsertAsync(T data);
	}
}
