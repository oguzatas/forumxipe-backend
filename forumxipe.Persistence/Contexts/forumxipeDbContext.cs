using forumxipe.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Persistence.Contexts
{
	public class forumxipeDbContext : DbContext
	{
		public forumxipeDbContext(DbContextOptions options) : base(options)
		{

		}

		DbSet<User> Users { get; set; }

		DbSet<Comment> Comments { get; set; }

		DbSet<Subforum> Subforums { get; set; }

		DbSet<Forum> Forums { get; set; }

		DbSet<Post> Posts { get; set; }









	}
}
