using forumxipe.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
	{
		Task<bool> AddAsync(T entity);

		Task<bool> AddRangeAsync(List<T> entity);

		bool Remove(T entity);

		bool Remove(string id);

		bool RemoveRange(List<T> entity);


		Task<bool> UpdateAsync(T entity);

		Task<int> SaveAsync();



		
	}
}
