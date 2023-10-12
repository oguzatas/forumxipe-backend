using forumxipe.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Domain.Entities
{
	public class Forum : BaseEntity
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public ICollection<Subforum> Subforums { get; set; }
	}
}
