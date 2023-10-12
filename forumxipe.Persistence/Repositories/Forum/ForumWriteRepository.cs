using forumxipe.Application.Repositories;
using forumxipe.Domain.Entities;
using forumxipe.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Persistence.Repositories
{
	public class ForumWriteRepository : WriteRepository<Forum>, IForumWriteRepository
	{
		public ForumWriteRepository(forumxipeDbContext context) : base(context)
		{
		}
	}
}
