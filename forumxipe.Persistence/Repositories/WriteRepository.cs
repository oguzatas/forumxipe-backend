using forumxipe.Application.Repositories;
using forumxipe.Domain.Entities.Common;
using forumxipe.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Persistence.Repositories
{
	public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
	{
		readonly private forumxipeDbContext _context;

        public WriteRepository(forumxipeDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

		public async Task<bool> AddAsync(T entity)
		{
			EntityEntry<T> entityEntry = await Table.AddAsync(entity);
			return entityEntry.State == EntityState.Added;
		}

		public async Task<bool> AddRangeAsync(List<T> entity)
		{
			await Table.AddRangeAsync(entity);
				return true;
		}

		public bool Remove(T entity)
		{
			EntityEntry<T> entityEntry = Table.Remove(entity);
			return entityEntry.State == EntityState.Deleted;
		}

		public async Task<bool> RemoveAsync(string id)
		{
			T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
			return Remove(model);
		}

		public bool RemoveRange(List<T> entity)
		{
			Table.RemoveRange(entity);
				return true;
		}

		public Task<int> SaveAsync()
		=> _context.SaveChangesAsync();

		public bool Update(T entity)
		{
			EntityEntry entityEntry= Table.Update(entity);
			return entityEntry.State == EntityState.Modified;
		}

		
	}
}
