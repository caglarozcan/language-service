using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API.Data.Repositories.Abstract.Base
{
	public abstract class Repository<T> : IRepository<T> where T : class, new()
	{
		private readonly APIContext _dbContext;

		public Repository(APIContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
		{
			IQueryable<T> query = _dbContext.Set<T>();

			if (predicate != null)
			{
				query = query.Where(predicate);
			}

			if (includes.Any())
			{
				foreach (var include in includes)
				{
					query = query.Include(include);
				}
			}

			return await query.FirstOrDefaultAsync();
		}

		public async Task InsertAsync(T data)
		{
			await _dbContext.Set<T>().AddAsync(data);
			await _dbContext.SaveChangesAsync();
		}
	}
}
