using API.Data.Entities;
using API.Data.Repositories.Abstract;
using API.Data.Repositories.Abstract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data.Repositories
{
	public class LanguageRepository : Repository<Languages>, ILanguageRepository
	{
		public LanguageRepository(APIContext dbContext) 
			: base(dbContext)
		{
		}
	}
}
