using forumxipe.Application.Abstraction;
using forumxipe.Persistence.Concretes.InMemory;
using forumxipe.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Persistence
{
    public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddDbContext<forumxipeDbContext>(options => options.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=12345;"));
			services.AddSingleton<IForumService, InMemoryForumService>();

		}
	}
}
