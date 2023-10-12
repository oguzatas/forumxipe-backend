﻿using forumxipe.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Domain.Entities
{
	public class Post : BaseEntity
	{
        public string Title { get; set; }

		public string Content { get; set; }

	    public ICollection<Comment> Comments { get; set; }
	}
}
