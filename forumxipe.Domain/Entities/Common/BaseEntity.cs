using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Domain.Entities.Common
{
	public class BaseEntity
	{
		public Guid Id { get; set; }

        public  DateTime CreateDate { get; set; } = DateTime.Now;

		public DateTime ChangeTime { get; set; }


	}
}
