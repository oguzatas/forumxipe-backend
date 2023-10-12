using forumxipe.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Domain.Entities
{
	public class User : BaseEntity
	{
        public string Name{ get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public ICollection<Comment> Comments { get; set; }

		public ICollection<Post> Posts { get; set; }

	}
}
