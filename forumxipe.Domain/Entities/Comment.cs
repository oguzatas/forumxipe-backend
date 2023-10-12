using forumxipe.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Domain.Entities
{
	public class Comment : BaseEntity
	{
        public string Content { get; set; }

        public Guid UserId { get; set; }
    }
}
